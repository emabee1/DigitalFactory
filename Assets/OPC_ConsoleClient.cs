using System.Collections.Generic;
using UnityEngine;
using Opc.Ua;
using Opc.Ua.Client;
using Opc.Ua.Configuration;
using System;
using System.Threading;
using System.Threading.Tasks;

public class OPC_ConsoleClient : MonoBehaviour
{
    MyClient client;
    static Session session;
    static Subscription subscription;

    // Start is called before the first frame update
    void Start()
    {
        print((Utils.IsRunningOnMono() ? "Mono" : ".Net Core") + " OPC UA Client");

        // options
        bool autoAccept = true;

        //string endpointURL = "opc.tcp://localhost:51210/UA/SampleServer";
        //string endpointURL = "opc.tcp://opcuaserver.com:48484";
        string endpointURL = "opc.tcp://milo.digitalpetri.com:62541/milo";

        client = new MyClient(endpointURL, autoAccept);
        client.Run();
    }

    /// <summary>
    /// <param name="endpointURL">ServerURL to connect to</param>
    /// <param name="autoAccept">if true - accept untrusted Certificates</param>
    /// </summary>
    public class MyClient
    {
        string endpointURL;
        static bool autoAccept = true;

        public MyClient(string _endpointURL, bool _autoAccept)
        {
            endpointURL = _endpointURL;
            autoAccept = _autoAccept;
        }

        public void Run()
        {
            try
            {
                Client().Wait();
            }
            catch (Exception ex)
            {
                print("ServiceResultException: " + ex.Message);
                print("Exception: " + ex.Message);
                return;
            }
        }

        private async Task Client()
        {
            print("1 - Create an Application Configuration.");

            ApplicationInstance application = new ApplicationInstance
            {
                ApplicationName = "UA Core Sample Client",
                ApplicationType = ApplicationType.Client,
                ConfigSectionName = Utils.IsRunningOnMono() ? "Opc.Ua.MonoSampleClient" : "Opc.Ua.SampleClient"
            };

            print("ApplicationInstance: " + application);

            // load the application configuration.
            ApplicationConfiguration config = await application.LoadApplicationConfiguration(false);
            print("ApplicationConfiguration loaded: " + config);

            // check the application certificate.
            bool haveAppCertificate = await application.CheckApplicationInstanceCertificate(false, 0);
            if (!haveAppCertificate)
            {
                throw new Exception("Application instance certificate invalid!");
            }

            if (haveAppCertificate)
            {
                config.ApplicationUri = Utils.GetApplicationUriFromCertificate(config.SecurityConfiguration.ApplicationCertificate.Certificate);
                if (config.SecurityConfiguration.AutoAcceptUntrustedCertificates)
                {
                    autoAccept = true;
                }
                config.CertificateValidator.CertificateValidation += new CertificateValidationEventHandler(CertificateValidator_CertificateValidation);
            }
            else
            {
                print("WARN: missing application certificate, using unsecure connection.");
            }

            print("ApplicationConfiguration validated");

            print("2 - Discover endpoints of: " + endpointURL);
            var selectedEndpoint = CoreClientUtils.SelectEndpoint(endpointURL, false, 15000);
            print("    Selected endpoint uses: " +
                selectedEndpoint.SecurityPolicyUri.Substring(selectedEndpoint.SecurityPolicyUri.LastIndexOf('#') + 1));

            print("3 - Create a session with OPC UA server.");
            var endpointConfiguration = EndpointConfiguration.Create(config);
            var endpoint = new ConfiguredEndpoint(null, selectedEndpoint, endpointConfiguration);
            session = await Session.Create(config, endpoint, false, "OPC UA Client", 60000, new UserIdentity(new AnonymousIdentityToken()), null);


            print("4 - Browse the OPC UA server namespace.");
            ReferenceDescriptionCollection references;
            Byte[] continuationPoint;

            references = session.FetchReferences(ObjectIds.ObjectsFolder);

            session.Browse(
                null,
                null,
                ObjectIds.ObjectsFolder,
                0u,
                BrowseDirection.Forward,
                ReferenceTypeIds.HierarchicalReferences,
                true,
                (uint)NodeClass.Variable | (uint)NodeClass.Object | (uint)NodeClass.Method,
                out continuationPoint,
                out references);

            //print(" DisplayName, BrowseName, NodeClass");
            //foreach (var rd in references)
            //{
            //    print(rd.DisplayName + " " + rd.BrowseName + " " + rd.NodeClass);
            //    ReferenceDescriptionCollection nextRefs;
            //    byte[] nextCp;
            //    session.Browse(
            //        null,
            //        null,
            //        ExpandedNodeId.ToNodeId(rd.NodeId, session.NamespaceUris),
            //        0u,
            //        BrowseDirection.Forward,
            //        ReferenceTypeIds.HierarchicalReferences,
            //        true,
            //        (uint)NodeClass.Variable | (uint)NodeClass.Object | (uint)NodeClass.Method,
            //        out nextCp,
            //        out nextRefs);

            //    foreach (var nextRd in nextRefs)
            //    {
            //        print(nextRd.DisplayName + " " + nextRd.BrowseName + " " + nextRd.NodeClass);
            //    }
            //}

            print("5 - Create a subscription with publishing interval of 10 second.");
            subscription = new Subscription(session.DefaultSubscription) { PublishingInterval = 10000 };

            print("6 - Add a list of items (server current time and status) to the subscription.");
            var list = new List<MonitoredItem> {
                new MonitoredItem(subscription.DefaultItem)
                {
                    DisplayName = "ServerStatusCurrentTime", StartNodeId = "i="+Variables.Server_ServerStatus_CurrentTime.ToString()
                }
            };

            //add new items to subscribe to
            subscription.AddItems(list);

            list.ForEach(i => i.Notification += OnNotification);


            print("7 - Add the subscription to the session.");
            session.AddSubscription(subscription);
            subscription.Create();
        }

        private static void OnNotification(MonitoredItem item, MonitoredItemNotificationEventArgs e)
        {
            foreach (var value in item.DequeueValues())
            {
                print(item.DisplayName + " " + value.Value + " " + value.SourceTimestamp + " " + value.StatusCode);
            }
        }

        private static void CertificateValidator_CertificateValidation(CertificateValidator validator, CertificateValidationEventArgs e)
        {
            if (e.Error.StatusCode == StatusCodes.BadCertificateUntrusted)
            {
                e.Accept = autoAccept;
                if (autoAccept)
                {
                    print("Accepted Certificate: " + e.Certificate.Subject);
                }
                else
                {
                    print("Rejected Certificate: " + e.Certificate.Subject);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!Application.isPlaying)
        {
            session.RemoveSubscription(subscription);
            session.Dispose();
        }
    }
}

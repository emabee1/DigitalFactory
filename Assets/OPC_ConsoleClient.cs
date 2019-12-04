using Opc.Ua;
using Opc.Ua.Client;
using Opc.Ua.Configuration;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class OPC_ConsoleClient : MonoBehaviour
{
    MyClient client;
    static Session session;
    static Subscription subscription;

    private static KukaFrontMovement kukaFrontMovement;
    private static KukaBackMovement kukaBackMovement;
    private static AutoServus autoServus;


    private void Awake()
    {
        kukaBackMovement = GameObject.FindObjectOfType<KukaBackMovement>();
        kukaFrontMovement = GameObject.FindObjectOfType<KukaFrontMovement>();
        autoServus = GameObject.FindObjectOfType<AutoServus>();
    }

    // Start is called before the first frame update
    void Start()
    {
        // options
        bool autoAccept = true;

        //string endpointURL = "opc.tcp://milo.digitalpetri.com:62541/milo";
        string endpointURL = "opc.tcp://193.170.2.252:30005";

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
                ApplicationName = "Kuka Client",
                ApplicationType = ApplicationType.Client,
                ConfigSectionName = Utils.IsRunningOnMono() ? "Opc.Ua.MonoSampleClient" : "Opc.Ua.SampleClient"
            };

            // load the application configuration.
            ApplicationConfiguration config = await application.LoadApplicationConfiguration(false);
            print("Application Configured");

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

            print("2 - Discover endpoints of: " + endpointURL);
            var selectedEndpoint = CoreClientUtils.SelectEndpoint(endpointURL, false, 15000);

            print("Selected endpoint uses: " +
                selectedEndpoint.SecurityPolicyUri.Substring(selectedEndpoint.SecurityPolicyUri.LastIndexOf('#') + 1) + " Certificat" );

            print("3 - Create a session with OPC UA server.");
            var endpointConfiguration = EndpointConfiguration.Create(config);
            var endpoint = new ConfiguredEndpoint(null, selectedEndpoint, endpointConfiguration);
            session = await Session.Create(config, endpoint, false, "OPC UA Console Client", 60000, new UserIdentity(new AnonymousIdentityToken()), null);
            print("session Created");


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

            foreach (var rd in references)
            {
                ReferenceDescriptionCollection nextRefs;
                byte[] nextCp;
                session.Browse(
                    null,
                    null,
                    ExpandedNodeId.ToNodeId(rd.NodeId, session.NamespaceUris),
                    0u,
                    BrowseDirection.Forward,
                    ReferenceTypeIds.HierarchicalReferences,
                    true,
                    (uint)NodeClass.Variable | (uint)NodeClass.Object | (uint)NodeClass.Method,
                    out nextCp,
                    out nextRefs);
            }

            print("5 - Create a subscription with publishing interval of 10 second.");
            subscription = new Subscription(session.DefaultSubscription) { PublishingInterval = 500 };

            print("6 - Add a list of items to the subscription.");
            #region Subscribe to Kuka Items
            var list = new List<MonitoredItem> {
                new MonitoredItem(subscription.DefaultItem)
                {
                    DisplayName = "7",
                    StartNodeId = "ns=2;s=Axis:7:j"
                },
                new MonitoredItem(subscription.DefaultItem)
                {
                    DisplayName = "6",
                    StartNodeId = "ns=2;s=Axis:6:j"
                },
                                new MonitoredItem(subscription.DefaultItem)
                {
                    DisplayName = "5",
                    StartNodeId = "ns=2;s=Axis:5:j"
                },
                new MonitoredItem(subscription.DefaultItem)
                {
                    DisplayName = "4",
                    StartNodeId = "ns=2;s=Axis:4:j"
                },
                                new MonitoredItem(subscription.DefaultItem)
                {
                    DisplayName = "3",
                    StartNodeId = "ns=2;s=Axis:3:j"
                },
                new MonitoredItem(subscription.DefaultItem)
                {
                    DisplayName = "2",
                    StartNodeId = "ns=2;s=Axis:2:j"
                },
                                new MonitoredItem(subscription.DefaultItem)
                {
                    DisplayName = "1",
                    StartNodeId = "ns=2;s=Axis:1:j"
                }
            };
            #endregion


            #region Subscribe to Milo Items
            //var list = new List<MonitoredItem> {
            //    new MonitoredItem(subscription.DefaultItem)
            //    {
            //        DisplayName = "1",
            //        StartNodeId = "ns=2;s=Dynamic/RandomDouble"
            //    },
            //    new MonitoredItem(subscription.DefaultItem)
            //    {
            //        DisplayName = "2",
            //        StartNodeId = "ns=2;s=Dynamic/RandomDouble"
            //    },
            //                    new MonitoredItem(subscription.DefaultItem)
            //    {
            //        DisplayName = "3",
            //        StartNodeId = "ns=2;s=Dynamic/RandomDouble"
            //    },
            //    new MonitoredItem(subscription.DefaultItem)
            //    {
            //        DisplayName = "4",
            //        StartNodeId = "ns=2;s=Dynamic/RandomDouble"
            //    },
            //                    new MonitoredItem(subscription.DefaultItem)
            //    {
            //        DisplayName = "5",
            //        StartNodeId = "ns=2;s=Dynamic/RandomDouble"
            //    },
            //    new MonitoredItem(subscription.DefaultItem)
            //    {
            //        DisplayName = "6",
            //        StartNodeId = "ns=2;s=Dynamic/RandomDouble"
            //    },
            //                    new MonitoredItem(subscription.DefaultItem)
            //    {
            //        DisplayName = "7",
            //        StartNodeId = "ns=2;s=Dynamic/RandomDouble"
            //    },
            //    new MonitoredItem(subscription.DefaultItem)
            //    {
            //        DisplayName = "8",
            //        StartNodeId = "ns=2;s=Dynamic/RandomDouble"
            //    }               
            //};
            #endregion

            subscription.AddItems(list);

            list.ForEach(i => i.Notification += OnNotification);

            print("7 - Add the subscription to the session.");
            session.AddSubscription(subscription);
            subscription.Create();
            print("8 - Subscription added");
            print("9 - Client Running");
        }

        private static void OnNotification(MonitoredItem item, MonitoredItemNotificationEventArgs e)
        {
            foreach (var value in item.DequeueValues())
            {
                //print(item.DisplayName + " Value : " + value.Value);
                kukaBackMovement.ProcessServerInput((double)value.Value, Int32.Parse(item.DisplayName));
                //kukaFrontMovement.ProcessServerInput((double)value.Value, Int32.Parse(item.DisplayName));
                autoServus.ProcessServerInput((double)value.Value, Int32.Parse(item.DisplayName));
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

    private void OnDestroy()
    {
        session.RemoveSubscription(subscription);
        session.Dispose();
        print("SessionDisposed");
    }
}

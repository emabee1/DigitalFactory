using System;
using UnityEngine;
using System.Collections;
using System.Net.Sockets;
using System.Net;

public class OPC_UA : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class Client
{
    static Client client = null;

    private Client()
    {

    }

    public static Client Init()
    {
        if (client == null)
        {
            return client = new Client();
        }
        return client;
    }

    public string Connect(String server, String message)
    {
        try
        {
            Int32 port = 4840;
            TcpClient client = new TcpClient(server, port);

            Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

            NetworkStream stream = client.GetStream();
            stream.Write(data, 0, data.Length);
            
            data = new Byte[256];
            String responseData = String.Empty;
            Int32 bytes = stream.Read(data, 0, data.Length);
            responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
            
            stream.Close();
            client.Close();
            return System.Text.Encoding.ASCII.GetString(data, 0, bytes);
        }
        catch (ArgumentNullException e)
        {
            Console.WriteLine("ArgumentNullException: {0}", e);
        }
        catch (SocketException e)
        {
            Console.WriteLine("SocketException: {0}", e);
        }

        return "false";
    }
}



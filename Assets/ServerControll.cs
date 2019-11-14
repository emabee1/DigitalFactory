using System;
using UnityEngine;


public class ServerControll : MonoBehaviour
{
    public GameObject part8;
    public GameObject part7;
    public GameObject part6;
    public GameObject part5;
    public GameObject part4;
    public GameObject part3;
    public GameObject part2;

    private Vector3 position8 = new Vector3(0, 0, 0);
    private Vector3 position7 = new Vector3(0, 0, 0);
    private Vector3 position6 = new Vector3(0, 0, 0);
    private Vector3 position5 = new Vector3(0, 0, 0);
    private Vector3 position4 = new Vector3(0, 0, 0);
    private Vector3 position3 = new Vector3(0, 0, 0);
    private Vector3 position2 = new Vector3(0, 0, 0);


    //Client client = Client.Init();


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    //    string data = client.Connect("127.0.0.1", "hello");
    //    print("incoming: " + data);
    //    int[] positions = new int[8];
    //    positions[0] = 0;
    //    int pos = 0;
    //    for (int k = 1; k < 8; k++)
    //    {
    //        positions[k] = data.IndexOf(";", pos);
    //        pos = positions[k] + 1;
    //    }

    //    int pos8 = Int32.Parse(data.Substring(0, positions[1]));
    //    int pos7 = Int32.Parse(data.Substring(positions[1] + 1, (positions[2] - positions[1]) - 1));
    //    int pos6 = Int32.Parse(data.Substring(positions[2] + 1, (positions[3] - positions[2]) - 1));
    //    int pos5 = Int32.Parse(data.Substring(positions[3] + 1, (positions[4] - positions[3]) - 1));
    //    int pos4 = Int32.Parse(data.Substring(positions[4] + 1, (positions[5] - positions[4]) - 1));
    //    int pos3 = Int32.Parse(data.Substring(positions[5] + 1, (positions[6] - positions[5]) - 1));
    //    int pos2 = Int32.Parse(data.Substring(positions[6] + 1, (positions[7] - positions[6]) - 1));

    //    part8.transform.localEulerAngles = new Vector3(0, pos8, 0);
    //    part6.transform.localEulerAngles = new Vector3(0, pos6, 0);
    //    part4.transform.localEulerAngles = new Vector3(0, pos4, 0);
    //    part2.transform.localEulerAngles = new Vector3(0, pos2, 0);
    }
}

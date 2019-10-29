using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoServus : MonoBehaviour
{
    public GameObject servus;

    private Vector3 Ausgabe = new Vector3(0.44f, 0.853f, 1f);   
    private Vector3 Kuka = new Vector3(0.44f, 0.853f, 2.255f);
    private Vector3 Fraese = new Vector3(0.44f, 0.853f, 3.975f);
    private Vector3 Lager = new Vector3(0.44f, 0.853f, 6.223f);
    private bool toAusgabe = false;
    private bool toKuka = false;
    private bool toFraese = false;
    private bool toLager = false;



    public GameObject Box;
    private Vector3 Left = new Vector3(-0.571f, 0.14f, 1.38292f);    
    private Vector3 Center = new Vector3(-0.571f, 0.14f, 0.572f);    
    private Vector3 Right = new Vector3(-0.571f, 0.14f, -0.2167f);
    private bool toLeft = false;
    private bool toCenter = false;
    private bool toRight = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            toAusgabe = true;
            toKuka = false;
            toFraese = false;
            toLager = false;
}
        if (toAusgabe)
        {
            if (Vector3.Distance(servus.transform.position, Ausgabe) > 0.01)
            {
                servus.transform.position = Vector3.Lerp(servus.transform.position, Ausgabe, 0.1f);
            }
            else
            {
                servus.transform.position = Ausgabe;
                toAusgabe = false;
                toLeft = true;
                toCenter = false;
                toRight = false;
            }
        }

        if (Input.GetKeyDown("o"))
        {
            toAusgabe = false;
            toKuka = true;
            toFraese = false;
            toLager = false;
        }
        if (toKuka)
        {
            if (Vector3.Distance(servus.transform.position, Kuka) > 0.01)
            {
                servus.transform.position = Vector3.Lerp(servus.transform.position, Kuka, 0.1f);
            }
            else
            {
                servus.transform.position = Kuka;
                toKuka = false;
                toLeft = false;
                toCenter = false;
                toRight = true;
            }
        }

        if (Input.GetKeyDown("i"))
        {
            toAusgabe = false;
            toKuka = false;
            toFraese = true;
            toLager = false;
        }
        if (toFraese)
        {
            if (Vector3.Distance(servus.transform.position, Fraese) > 0.01)
            {
                servus.transform.position = Vector3.Lerp(servus.transform.position, Fraese, 0.1f);
            }
            else
            {
                servus.transform.position = Fraese;
                toFraese = false;
                toLeft = true;
                toCenter = false;
                toRight = false;
            }
        }

        if (Input.GetKeyDown("u"))
        {
            toAusgabe = false;
            toKuka = false;
            toFraese = false;
            toLager = true;
        }
        if (toLager)
        {
            if (Vector3.Distance(servus.transform.position, Lager) > 0.01)
            {
                servus.transform.position = Vector3.Lerp(servus.transform.position, Lager, 0.1f);
            }
            else
            {
                servus.transform.position = Lager;
                toLager = false;
                toLeft = false;
                toCenter = false;
                toRight = true;
            }
        }


        if (Input.GetKeyDown("z"))
        {
            toLeft = false;
            toCenter = true;
            toRight = false;
        }
        if (toCenter)
        {
            if (Vector3.Distance(Box.transform.localPosition, Center) > 0.01)
            {
                Box.transform.localPosition = Vector3.Lerp(Box.transform.localPosition, Center, 0.1f);
            }
            else
            {
                Box.transform.localPosition = Center;
                toCenter = false;
            }
        }

        if (Input.GetKeyDown("r"))
        {
            toLeft = false;
            toCenter = false;
            toRight = true;
        }
        if (toRight)
        {
            if (Vector3.Distance(Box.transform.localPosition, Right) > 0.01)
            {
                Box.transform.localPosition = Vector3.Lerp(Box.transform.localPosition, Right, 0.1f);
            }
            else
            {
                Box.transform.localPosition = Right;
                toRight = false;
            }
        }


        if (Input.GetKeyDown("l"))
        {
            toLeft = true;
            toCenter = false;
            toRight = false;
        }
        if (toLeft)
        {
            if (Vector3.Distance(Box.transform.localPosition, Left) > 0.01)
            {
                Box.transform.localPosition = Vector3.Lerp(Box.transform.localPosition, Left, 0.1f);
            }
            else
            {
                Box.transform.localPosition = Left;
                toLeft = false;
            }
        }
    }
}

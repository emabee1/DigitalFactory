using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KukaBackMovement : MonoBehaviour
{
    public GameObject part8;
    public GameObject part7;
    public GameObject part6;
    public GameObject part5;
    public GameObject part4;
    public GameObject part3;
    public GameObject part2;

    public Vector3 moveY = new Vector3(0, 1, 0);
    public Vector3 moveZ = new Vector3(0, 0, 1);

    private Vector3 position8 = new Vector3(0, 0, 0);
    private Vector3 position7 = new Vector3(0, 0, 0);
    private Vector3 position6 = new Vector3(0, 0, 0);
    private Vector3 position5 = new Vector3(0, 0, 0);
    private Vector3 position4 = new Vector3(0, 0, 0);
    private Vector3 position3 = new Vector3(0, 0, 0);
    private Vector3 position2 = new Vector3(0, 0, 0);

    private Vector3 to8;
    private Vector3 to7;
    private Vector3 to6;
    private Vector3 to5;
    private Vector3 to4;
    private Vector3 to3;
    private Vector3 to2;
    
    private bool GetPart = false;
    private bool SetPart = false;
    private bool TurnPart = false;
    private bool ReturnHome = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F1))
        {
            GetPart = true;
            SetPart = false;
            TurnPart = false;
            ReturnHome = false;
            to8 = new Vector3(0, 22, 0);
            to7 = new Vector3(0, 0, 113);
            to6 = new Vector3(0, 254, 0);
            to5 = new Vector3(0, 0, 245);
            to4 = new Vector3(0, 334, 0);
            to3 = new Vector3(0, 0, 323);
            to2 = new Vector3(0, 359, 0);
        }
        if (GetPart)
        {
            if (Vector3.Distance(part8.transform.localEulerAngles, to8) > 1f)
            {
                position8 += moveY;
                part8.transform.localEulerAngles = position8;
            }
            else
            {
                part8.transform.localEulerAngles = to8;
            }

            if (Vector3.Distance(part7.transform.localEulerAngles, to7) > 1f)
            {
                position7 += moveZ;
                part7.transform.localEulerAngles = position7;
            }
            else
            {
                part7.transform.localEulerAngles = to7;
            }

            if (Vector3.Distance(part6.transform.localEulerAngles, to6) > 1f)
            {
                position6 -= moveY;
                part6.transform.localEulerAngles = position6;
            }
            else
            {
                part6.transform.localEulerAngles = to6;
            }

            if (Vector3.Distance(part5.transform.localEulerAngles, to5) > 1f)
            {
                position5 -= moveZ;
                part5.transform.localEulerAngles = position5;
            }
            else
            {
                part5.transform.localEulerAngles = to5;
                //GetPart = false;
            }

            if (Vector3.Distance(part4.transform.localEulerAngles, to4) > 1f)
            {
                position4 -= moveY;
                part4.transform.localEulerAngles = position4;
            }
            else
            {
                part4.transform.localEulerAngles = to4;
            }

            if (Vector3.Distance(part3.transform.localEulerAngles, to3) > 1f)
            {
                position3 -= moveZ;
                part3.transform.localEulerAngles = position3;
            }
            else
            {
                part3.transform.localEulerAngles = to3;
            }

            if (Vector3.Distance(part2.transform.localEulerAngles, to2) > 1f)
            {
                position2 -= moveY;
                part2.transform.localEulerAngles = position2;
            }
            else
            {
                part2.transform.localEulerAngles = to2;
            }
        }

        if (Input.GetKeyDown(KeyCode.F2))
        {
            GetPart = false;
            SetPart = true;
            TurnPart = false;
            ReturnHome = false;
            to8 = new Vector3(0, 341, 0);
            to7 = new Vector3(0, 0, 111);
            to6 = new Vector3(0, 276, 0);
            to5 = new Vector3(0, 0, 287);
            to4 = new Vector3(0, 340, 0);
            to3 = new Vector3(0, 0, 324);
            to2 = new Vector3(0, 6, 0);
        }
        if (SetPart)
        {
            if (Vector3.Distance(part8.transform.localEulerAngles, to8) > 1f)
            {
                position8 -= moveY;
                part8.transform.localEulerAngles = position8;
            }
            else
            {
                part8.transform.localEulerAngles = to8;
            }

            if (Vector3.Distance(part7.transform.localEulerAngles, to7) > 1f)
            {
                position7 -= moveZ;
                part7.transform.localEulerAngles = position7;
            }
            else
            {
                part7.transform.localEulerAngles = to7;
            }

            if (Vector3.Distance(part6.transform.localEulerAngles, to6) > 1f)
            {
                position6 += moveY;
                part6.transform.localEulerAngles = position6;
            }
            else
            {
                part6.transform.localEulerAngles = to6;
            }

            if (Vector3.Distance(part5.transform.localEulerAngles, to5) > 1f)
            {
                position5 += moveZ;
                part5.transform.localEulerAngles = position5;
            }
            else
            {
                part5.transform.localEulerAngles = to5;
                GetPart = false;
            }

            if (Vector3.Distance(part4.transform.localEulerAngles, to4) > 1f)
            {
                position4 += moveY;
                part4.transform.localEulerAngles = position4;
            }
            else
            {
                part4.transform.localEulerAngles = to4;
            }

            if (Vector3.Distance(part3.transform.localEulerAngles, to3) > 1f)
            {
                position3 += moveZ;
                part3.transform.localEulerAngles = position3;
            }
            else
            {
                part3.transform.localEulerAngles = to3;
            }

            if (Vector3.Distance(part2.transform.localEulerAngles, to2) > 1f)
            {
                position2 += moveY;
                part2.transform.localEulerAngles = position2;
            }
            else
            {
                part2.transform.localEulerAngles = to2;
            }
        }

        if (Input.GetKeyDown(KeyCode.F3))
        {
            GetPart = false;
            SetPart = false;
            TurnPart = true;
            ReturnHome = false;

            to8 = new Vector3(0, 331, 0);
            to7 = new Vector3(0, 0, 119);
            to6 = new Vector3(0, 269, 0);
            to5 = new Vector3(0, 0, 269);
            to4 = new Vector3(0, 156, 0);
            to3 = new Vector3(0, 0, 26);
            to2 = new Vector3(0, 356, 0);
        }
        if (TurnPart)
        {
            if (Vector3.Distance(part8.transform.localEulerAngles, to8) > 1f)
            {
                position8 -= moveY;
                part8.transform.localEulerAngles = position8;
            }
            else
            {
                part8.transform.localEulerAngles = to8;
            }

            if (Vector3.Distance(part7.transform.localEulerAngles, to7) > 1f)
            {
                position7 += moveZ;
                part7.transform.localEulerAngles = position7;
            }
            else
            {
                part7.transform.localEulerAngles = to7;
            }

            if (Vector3.Distance(part6.transform.localEulerAngles, to6) > 1f)
            {
                position6 -= moveY;
                part6.transform.localEulerAngles = position6;
            }
            else
            {
                part6.transform.localEulerAngles = to6;
            }

            if (Vector3.Distance(part5.transform.localEulerAngles, to5) > 1f)
            {
                position5 -= moveZ;
                part5.transform.localEulerAngles = position5;
            }
            else
            {
                part5.transform.localEulerAngles = to5;
            }

            if (Vector3.Distance(part4.transform.localEulerAngles, to4) > 1f)
            {
                position4 -= moveY;
                part4.transform.localEulerAngles = position4;
            }
            else
            {
                part4.transform.localEulerAngles = to4;
            }

            if (Vector3.Distance(part3.transform.localEulerAngles, to3) > 1f)
            {
                position3 += moveZ;
                part3.transform.localEulerAngles = position3;
            }
            else
            {
                part3.transform.localEulerAngles = to3;
            }

            if (Vector3.Distance(part2.transform.localEulerAngles, to2) > 1f)
            {
                position2 -= moveY;
                part2.transform.localEulerAngles = position2;
            }
            else
            {
                part2.transform.localEulerAngles = to2;
            }
        }

        if (Input.GetKeyDown(KeyCode.F4))
        {
            GetPart = false;
            SetPart = false;
            TurnPart = false;
            ReturnHome = true;
            to8 = new Vector3(0, 0, 0);
            to7 = new Vector3(0, 0, 0);
            to6 = new Vector3(0, 0, 0);
            to5 = new Vector3(0, 0, 0);
            to4 = new Vector3(0, 0, 0);
            to3 = new Vector3(0, 0, 0);
            to2 = new Vector3(0, 0, 0);
        }
        if (ReturnHome)
        {
            if (Vector3.Distance(part8.transform.localEulerAngles, to8) > 1f)
            {
                position8 += moveY;
                part8.transform.localEulerAngles = position8;
            }
            else
            {
                part8.transform.localEulerAngles = to8;
            }

            if (Vector3.Distance(part7.transform.localEulerAngles, to7) > 1f)
            {
                position7 -= moveZ;
                part7.transform.localEulerAngles = position7;
            }
            else
            {
                part7.transform.localEulerAngles = to7;
            }

            if (Vector3.Distance(part6.transform.localEulerAngles, to6) > 1f)
            {
                position6 += moveY;
                part6.transform.localEulerAngles = position6;
            }
            else
            {
                part6.transform.localEulerAngles = to6;
            }

            if (Vector3.Distance(part5.transform.localEulerAngles, to5) > 1f)
            {
                position5 += moveZ;
                part5.transform.localEulerAngles = position5;
            }
            else
            {
                part5.transform.localEulerAngles = to5;
            }

            if (Vector3.Distance(part4.transform.localEulerAngles, to4) > 1f)
            {
                position4 -= moveY;
                part4.transform.localEulerAngles = position4;
            }
            else
            {
                part4.transform.localEulerAngles = to4;
            }

            if (Vector3.Distance(part3.transform.localEulerAngles, to3) > 1f)
            {
                position3 -= moveZ;
                part3.transform.localEulerAngles = position3;
            }
            else
            {
                part3.transform.localEulerAngles = to3;
            }

            if (Vector3.Distance(part2.transform.localEulerAngles, to2) > 1f)
            {
                position2 += moveY;
                part2.transform.localEulerAngles = position2;
            }
            else
            {
                part2.transform.localEulerAngles = to2;
            }
        }

        if (Input.GetKeyDown(KeyCode.F12))
        {
            GetPart = false;
            SetPart = false;
            TurnPart = false;
            ReturnHome = false;
        }
    }
}



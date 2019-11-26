using UnityEngine;

public class KukaFrontMovement : MonoBehaviour
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

    private bool Top = false;
    private bool Bottom = false;
    private bool ReturnHome = false;
    private bool PositionChanged = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PositionChanged)
        {
            print("KukaFront moves");
            part8.transform.localEulerAngles = to8;
            part7.transform.localEulerAngles = to7;
            part6.transform.localEulerAngles = to6;
            part5.transform.localEulerAngles = to5;
            part4.transform.localEulerAngles = to4;
            part3.transform.localEulerAngles = to3;
            part2.transform.localEulerAngles = to2;
            PositionChanged = false;
        }

        if (Input.GetKeyDown(KeyCode.F5))
        {
            Top = true;
            Bottom = false;
            ReturnHome = false;
            to8 = new Vector3(0, 347, 0);
            to7 = new Vector3(0, 0, 72);
            to6 = new Vector3(0, 113, 0);
            to5 = new Vector3(0, 0, 313);
            to4 = new Vector3(0, 63, 0);
            to3 = new Vector3(0, 0, 276);
            to2 = new Vector3(0, 31, 0);
        }
        if (Top)
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
                position6 += moveY;
                part6.transform.localEulerAngles = position6;
            }
            else
            {
                part6.transform.localEulerAngles = to6;
                Top = false;
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
                position4 += moveY;
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

        if (Input.GetKeyDown(KeyCode.F6))
        {
            Top = false;
            Bottom = true;
            ReturnHome = false;
            to8 = new Vector3(0, 332, 0);
            to7 = new Vector3(0, 0, 51);
            to6 = new Vector3(0, 163, 0);
            to5 = new Vector3(0, 0, 285);
            to4 = new Vector3(0, 19, 0);
            to3 = new Vector3(0, 0, 306);
            to2 = new Vector3(0, 39, 0);
        }
        if (Bottom)
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
                Top = false;
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
                position2 += moveY;
                part2.transform.localEulerAngles = position2;
            }
            else
            {
                part2.transform.localEulerAngles = to2;
            }
        }

        if (Input.GetKeyDown(KeyCode.F7))
        {
            Top = false;
            Bottom = false;
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
                position6 -= moveY;
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

        if (Input.GetKeyDown(KeyCode.F12))
        {
            Top = false;
            Bottom = false;
            ReturnHome = false;
        }
    }

    public void ProcessServerInput(double coord, int displayname)
    {
        //print("Coord: " + coord + "displayName: " + displayname);
        PositionChanged = true;
        switch (displayname)
        {
            case 8:
                to8 = new Vector3(0, (float)coord*100, 0);
                break;
            case 7:
                to7 = new Vector3(0, 0, (float)coord * 100);
                break;
            case 6:
                to6 = new Vector3(0, (float)coord * 100, 0);
                break;
            case 5:
                to5 = new Vector3(0, 0, (float)coord * 100);
                break;
            case 4:
                to4 = new Vector3(0, (float)coord * 100, 0);
                break;
            case 3:
                to3 = new Vector3(0, 0, (float)coord * 100);
                break;
            case 2:
                to2 = new Vector3(0, (float)coord * 100, 0);
                break;
            default:
                break;
        }

    }

    public void demo(double coord)
    {
        print("demo: " + coord);
        to8 = new Vector3(0, (float)coord * 100, 0);
        PositionChanged = true;
    }
}



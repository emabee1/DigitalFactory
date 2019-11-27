using UnityEngine;

public class KukaBackMovement : MonoBehaviour
{
    #region initial Attributes
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
    
    private bool boolGetPart = false;
    private bool boolSetPart = false;
    private bool boolTurnPart = false;
    private bool boolReturnHome = false;
    private bool boolPositionChanged = false;
    #endregion

    // Update is called once per frame
    void Update()
    {
        if (boolPositionChanged)
        {
            UpdatePosition();
        }

        if (Input.GetKeyDown(KeyCode.F1))
        {
            GetPart();
        }
        if (boolGetPart)
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
            SetPart();
        }
        if (boolSetPart)
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
            TurnPart();
        }
        if (boolTurnPart)
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
            ReturnHome();
        }
        if (boolReturnHome)
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
            StopMoving();
        }
    }

    //Method called by the OPC script
    public void ProcessServerInput(double coord, int displayname)
    {
        switch (displayname)
        {
            case 8:
                to8 = new Vector3(0, (float)coord * 100, 0);
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
        boolPositionChanged = true;
        boolGetPart = false;
        boolSetPart = false;
        boolTurnPart = false;
        boolReturnHome = false;

    }

    private void UpdatePosition()
    {
        print("KukaBack moves");
        part8.transform.localEulerAngles = to8;
        part7.transform.localEulerAngles = to7;
        part6.transform.localEulerAngles = to6;
        part5.transform.localEulerAngles = to5;
        part4.transform.localEulerAngles = to4;
        part3.transform.localEulerAngles = to3;
        part2.transform.localEulerAngles = to2;
        boolPositionChanged = false;
    }

    #region Methodes to set fix positions
    private void GetPart()
    {
        boolGetPart = true;
        boolSetPart = false;
        boolTurnPart = false;
        boolReturnHome = false;
        to8 = new Vector3(0, 22, 0);
        to7 = new Vector3(0, 0, 113);
        to6 = new Vector3(0, 254, 0);
        to5 = new Vector3(0, 0, 245);
        to4 = new Vector3(0, 334, 0);
        to3 = new Vector3(0, 0, 323);
        to2 = new Vector3(0, 359, 0);
    }

    private void SetPart()
    {
        boolGetPart = false;
        boolSetPart = true;
        boolTurnPart = false;
        boolReturnHome = false;
        to8 = new Vector3(0, 341, 0);
        to7 = new Vector3(0, 0, 111);
        to6 = new Vector3(0, 276, 0);
        to5 = new Vector3(0, 0, 287);
        to4 = new Vector3(0, 340, 0);
        to3 = new Vector3(0, 0, 324);
        to2 = new Vector3(0, 6, 0);
    }

    private void TurnPart()
    {
        boolGetPart = false;
        boolSetPart = false;
        boolTurnPart = true;
        boolReturnHome = false;

        to8 = new Vector3(0, 331, 0);
        to7 = new Vector3(0, 0, 119);
        to6 = new Vector3(0, 269, 0);
        to5 = new Vector3(0, 0, 269);
        to4 = new Vector3(0, 156, 0);
        to3 = new Vector3(0, 0, 26);
        to2 = new Vector3(0, 356, 0);
    }

    private void ReturnHome()
    {
        boolGetPart = false;
        boolSetPart = false;
        boolTurnPart = false;
        boolReturnHome = true;
        to8 = new Vector3(0, 0, 0);
        to7 = new Vector3(0, 0, 0);
        to6 = new Vector3(0, 0, 0);
        to5 = new Vector3(0, 0, 0);
        to4 = new Vector3(0, 0, 0);
        to3 = new Vector3(0, 0, 0);
        to2 = new Vector3(0, 0, 0);
    }

    private void StopMoving()
    {
        boolGetPart = false;
        boolSetPart = false;
        boolTurnPart = false;
        boolReturnHome = false;
    }
    #endregion
}



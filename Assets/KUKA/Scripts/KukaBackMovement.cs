using System;
using UnityEngine;

public class KukaBackMovement : MonoBehaviour
{
    #region initial Attributes
    public GameObject part7;
    public GameObject part6;
    public GameObject part5;
    public GameObject part4;
    public GameObject part3;
    public GameObject part2;
    public GameObject part1;

    public Vector3 moveY = new Vector3(0, 1, 0);
    public Vector3 moveZ = new Vector3(0, 0, 1);

    private Vector3 position8 = new Vector3(0, 0, 0);
    private Vector3 position7 = new Vector3(0, 0, 0);
    private Vector3 position6 = new Vector3(0, 0, 0);
    private Vector3 position5 = new Vector3(0, 0, 0);
    private Vector3 position4 = new Vector3(0, 0, 0);
    private Vector3 position3 = new Vector3(0, 0, 0);
    private Vector3 position2 = new Vector3(0, 0, 0);

    private Vector3 angle1;
    private Vector3 angle2;
    private Vector3 angle3;
    private Vector3 angle4;
    private Vector3 angle5;
    private Vector3 angle6;
    private Vector3 angle7;

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
            MoveToGetPart();
        }

        if (Input.GetKeyDown(KeyCode.F2))
        {
            SetPart();
        }
        if (boolSetPart)
        {
            MoveToSetPart();
        }

        if (Input.GetKeyDown(KeyCode.F3))
        {
            TurnPart();
        }
        if (boolTurnPart)
        {
            MoveToTurnPart();
        }

        if (Input.GetKeyDown(KeyCode.F4))
        {
            ReturnHome();
        }
        if (boolReturnHome)
        {
            MoveToReturnHome();
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
            case 7:
                coord = -coord;
                coord += 90;
                angle7 = new Vector3(0, (float)coord, 0);
                break;
            case 6:
                angle6 = new Vector3(0, 0, (float)coord);
                break;
            case 5:
                coord = -coord;
                coord += 180;
                angle5 = new Vector3(0, (float)coord, 0);
                break;
            case 4:
                angle4 = new Vector3(0, 0, (float)coord);
                break;
            case 3:
                coord = -coord;
                coord += 180;
                angle3 = new Vector3(0, (float)coord, 0);
                break;
            case 2:
                angle2 = new Vector3(0, 0, (float)coord);
                break;
            case 1:
                coord = -coord;
                angle1 = new Vector3(0, (float)coord, 0);
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
        part7.transform.localEulerAngles = angle1;
        part6.transform.localEulerAngles = angle2;
        part5.transform.localEulerAngles = angle3;
        part4.transform.localEulerAngles = angle4;
        part3.transform.localEulerAngles = angle5;
        part2.transform.localEulerAngles = angle6;
        part1.transform.localEulerAngles = angle7;
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

    #region Methodes to move Kuka
    private void MoveToGetPart()
    {
        if (Vector3.Distance(part7.transform.localEulerAngles, to8) > 1f)
        {
            position8 += moveY;
            part7.transform.localEulerAngles = position8;
        }
        else
        {
            part7.transform.localEulerAngles = to8;
        }

        if (Vector3.Distance(part6.transform.localEulerAngles, to7) > 1f)
        {
            position7 += moveZ;
            part6.transform.localEulerAngles = position7;
        }
        else
        {
            part6.transform.localEulerAngles = to7;
        }

        if (Vector3.Distance(part5.transform.localEulerAngles, to6) > 1f)
        {
            position6 -= moveY;
            part5.transform.localEulerAngles = position6;
        }
        else
        {
            part5.transform.localEulerAngles = to6;
        }

        if (Vector3.Distance(part4.transform.localEulerAngles, to5) > 1f)
        {
            position5 -= moveZ;
            part4.transform.localEulerAngles = position5;
        }
        else
        {
            part4.transform.localEulerAngles = to5;
        }

        if (Vector3.Distance(part3.transform.localEulerAngles, to4) > 1f)
        {
            position4 -= moveY;
            part3.transform.localEulerAngles = position4;
        }
        else
        {
            part3.transform.localEulerAngles = to4;
        }

        if (Vector3.Distance(part2.transform.localEulerAngles, to3) > 1f)
        {
            position3 -= moveZ;
            part2.transform.localEulerAngles = position3;
        }
        else
        {
            part2.transform.localEulerAngles = to3;
        }

        if (Vector3.Distance(part1.transform.localEulerAngles, to2) > 1f)
        {
            position2 -= moveY;
            part1.transform.localEulerAngles = position2;
        }
        else
        {
            part1.transform.localEulerAngles = to2;
        }
    }

    private void MoveToSetPart()
    {
        if (Vector3.Distance(part7.transform.localEulerAngles, to8) > 1f)
        {
            position8 -= moveY;
            part7.transform.localEulerAngles = position8;
        }
        else
        {
            part7.transform.localEulerAngles = to8;
        }

        if (Vector3.Distance(part6.transform.localEulerAngles, to7) > 1f)
        {
            position7 -= moveZ;
            part6.transform.localEulerAngles = position7;
        }
        else
        {
            part6.transform.localEulerAngles = to7;
        }

        if (Vector3.Distance(part5.transform.localEulerAngles, to6) > 1f)
        {
            position6 += moveY;
            part5.transform.localEulerAngles = position6;
        }
        else
        {
            part5.transform.localEulerAngles = to6;
        }

        if (Vector3.Distance(part4.transform.localEulerAngles, to5) > 1f)
        {
            position5 += moveZ;
            part4.transform.localEulerAngles = position5;
        }
        else
        {
            part4.transform.localEulerAngles = to5;
        }

        if (Vector3.Distance(part3.transform.localEulerAngles, to4) > 1f)
        {
            position4 += moveY;
            part3.transform.localEulerAngles = position4;
        }
        else
        {
            part3.transform.localEulerAngles = to4;
        }

        if (Vector3.Distance(part2.transform.localEulerAngles, to3) > 1f)
        {
            position3 += moveZ;
            part2.transform.localEulerAngles = position3;
        }
        else
        {
            part2.transform.localEulerAngles = to3;
        }

        if (Vector3.Distance(part1.transform.localEulerAngles, to2) > 1f)
        {
            position2 += moveY;
            part1.transform.localEulerAngles = position2;
        }
        else
        {
            part1.transform.localEulerAngles = to2;
        }
    }

    private void MoveToTurnPart()
    {
        if (Vector3.Distance(part7.transform.localEulerAngles, to8) > 1f)
        {
            position8 -= moveY;
            part7.transform.localEulerAngles = position8;
        }
        else
        {
            part7.transform.localEulerAngles = to8;
        }

        if (Vector3.Distance(part6.transform.localEulerAngles, to7) > 1f)
        {
            position7 += moveZ;
            part6.transform.localEulerAngles = position7;
        }
        else
        {
            part6.transform.localEulerAngles = to7;
        }

        if (Vector3.Distance(part5.transform.localEulerAngles, to6) > 1f)
        {
            position6 -= moveY;
            part5.transform.localEulerAngles = position6;
        }
        else
        {
            part5.transform.localEulerAngles = to6;
        }

        if (Vector3.Distance(part4.transform.localEulerAngles, to5) > 1f)
        {
            position5 -= moveZ;
            part4.transform.localEulerAngles = position5;
        }
        else
        {
            part4.transform.localEulerAngles = to5;
        }

        if (Vector3.Distance(part3.transform.localEulerAngles, to4) > 1f)
        {
            position4 -= moveY;
            part3.transform.localEulerAngles = position4;
        }
        else
        {
            part3.transform.localEulerAngles = to4;
        }

        if (Vector3.Distance(part2.transform.localEulerAngles, to3) > 1f)
        {
            position3 += moveZ;
            part2.transform.localEulerAngles = position3;
        }
        else
        {
            part2.transform.localEulerAngles = to3;
        }

        if (Vector3.Distance(part1.transform.localEulerAngles, to2) > 1f)
        {
            position2 -= moveY;
            part1.transform.localEulerAngles = position2;
        }
        else
        {
            part1.transform.localEulerAngles = to2;
        }
    }

    private void MoveToReturnHome()
    {
        if (Vector3.Distance(part7.transform.localEulerAngles, to8) > 1f)
        {
            position8 += moveY;
            part7.transform.localEulerAngles = position8;
        }
        else
        {
            part7.transform.localEulerAngles = to8;
        }

        if (Vector3.Distance(part6.transform.localEulerAngles, to7) > 1f)
        {
            position7 -= moveZ;
            part6.transform.localEulerAngles = position7;
        }
        else
        {
            part6.transform.localEulerAngles = to7;
        }

        if (Vector3.Distance(part5.transform.localEulerAngles, to6) > 1f)
        {
            position6 += moveY;
            part5.transform.localEulerAngles = position6;
        }
        else
        {
            part5.transform.localEulerAngles = to6;
        }

        if (Vector3.Distance(part4.transform.localEulerAngles, to5) > 1f)
        {
            position5 += moveZ;
            part4.transform.localEulerAngles = position5;
        }
        else
        {
            part4.transform.localEulerAngles = to5;
        }

        if (Vector3.Distance(part3.transform.localEulerAngles, to4) > 1f)
        {
            position4 -= moveY;
            part3.transform.localEulerAngles = position4;
        }
        else
        {
            part3.transform.localEulerAngles = to4;
        }

        if (Vector3.Distance(part2.transform.localEulerAngles, to3) > 1f)
        {
            position3 -= moveZ;
            part2.transform.localEulerAngles = position3;
        }
        else
        {
            part2.transform.localEulerAngles = to3;
        }

        if (Vector3.Distance(part1.transform.localEulerAngles, to2) > 1f)
        {
            position2 += moveY;
            part1.transform.localEulerAngles = position2;
        }
        else
        {
            part1.transform.localEulerAngles = to2;
        }
    }
    #endregion
}



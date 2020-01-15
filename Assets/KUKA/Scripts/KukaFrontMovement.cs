using System;
using UnityEngine;

public class KukaFrontMovement : MonoBehaviour
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

    private Vector3 position7 = new Vector3(0, 0, 0);
    private Vector3 position6 = new Vector3(0, 0, 0);
    private Vector3 position5 = new Vector3(0, 0, 0);
    private Vector3 position4 = new Vector3(0, 0, 0);
    private Vector3 position3 = new Vector3(0, 0, 0);
    private Vector3 position2 = new Vector3(0, 0, 0);
    private Vector3 position1 = new Vector3(0, 0, 0);

    private Vector3 angle1;
    private Vector3 angle2;
    private Vector3 angle3;
    private Vector3 angle4;
    private Vector3 angle5;
    private Vector3 angle6;
    private Vector3 angle7;

    private Vector3 to1;
    private Vector3 to2;
    private Vector3 to3;
    private Vector3 to4;
    private Vector3 to5;
    private Vector3 to6;
    private Vector3 to7;

    private bool boolTop = false;
    private bool boolBottom = false;
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

        if (Input.GetKeyDown(KeyCode.F5))
        {
            ToTop();
        }
        if (boolTop)
        {
            MoveToTop();
        }

        if (Input.GetKeyDown(KeyCode.F6))
        {
            ToBottom();
        }
        if (boolBottom)
        {
            MoveToBottom();
        }

        if (Input.GetKeyDown(KeyCode.F7))
        {
            ToReturnHome();
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
        //print("Coord: " + coord + "displayName: " + displayname);

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
        boolBottom = false;
        boolTop = false;
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
    private void ToTop()
    {
        boolTop = true;
        boolBottom = false;
        boolReturnHome = false;
        to1 = new Vector3(0, 347, 0);
        to2 = new Vector3(0, 0, 72);
        to5 = new Vector3(0, 113, 0);
        to4 = new Vector3(0, 0, 313);
        to3 = new Vector3(0, 63, 0);
        to2 = new Vector3(0, 0, 276);
        to1 = new Vector3(0, 31, 0);
    }

    private void ToBottom()
    {
        boolTop = false;
        boolBottom = true;
        boolReturnHome = false;
        to1 = new Vector3(0, 332, 0);
        to2 = new Vector3(0, 0, 51);
        to5 = new Vector3(0, 163, 0);
        to4 = new Vector3(0, 0, 285);
        to3 = new Vector3(0, 19, 0);
        to2 = new Vector3(0, 0, 306);
        to1 = new Vector3(0, 39, 0);
    }

    private void ToReturnHome()
    {
        boolTop = false;
        boolBottom = false;
        boolReturnHome = true;
        to1 = new Vector3(0, 0, 0);
        to2 = new Vector3(0, 0, 0);
        to5 = new Vector3(0, 0, 0);
        to4 = new Vector3(0, 0, 0);
        to3 = new Vector3(0, 0, 0);
        to2 = new Vector3(0, 0, 0);
        to1 = new Vector3(0, 0, 0);
    }

    private void StopMoving()
    {
        boolTop = false;
        boolBottom = false;
        boolReturnHome = false;
    }
    #endregion

    #region Methodes to move Kuka
    private void MoveToTop()
    {
        if (Vector3.Distance(part7.transform.localEulerAngles, to7) > 1f)
        {
            position7 -= moveY;
            part7.transform.localEulerAngles = position7;
        }
        else
        {
            part7.transform.localEulerAngles = to7;
        }


        if (Vector3.Distance(part6.transform.localEulerAngles, to6) > 1f)
        {
            position6 += moveZ;
            part6.transform.localEulerAngles = position6;
        }
        else
        {
            part6.transform.localEulerAngles = to6;
        }


        if (Vector3.Distance(part5.transform.localEulerAngles, to5) > 1f)
        {
            position5 += moveY;
            part5.transform.localEulerAngles = position5;
        }
        else
        {
            part5.transform.localEulerAngles = to5;
            boolTop = false;
        }

        if (Vector3.Distance(part4.transform.localEulerAngles, to4) > 1f)
        {
            position4 -= moveZ;
            part4.transform.localEulerAngles = position4;
        }
        else
        {
            part4.transform.localEulerAngles = to4;
        }


        if (Vector3.Distance(part3.transform.localEulerAngles, to3) > 1f)
        {
            position3 += moveY;
            part3.transform.localEulerAngles = position3;
        }
        else
        {
            part3.transform.localEulerAngles = to3;
        }


        if (Vector3.Distance(part2.transform.localEulerAngles, to2) > 1f)
        {
            position2 -= moveZ;
            part2.transform.localEulerAngles = position2;
        }
        else
        {
            part2.transform.localEulerAngles = to2;
        }


        if (Vector3.Distance(part1.transform.localEulerAngles, to1) > 1f)
        {
            position1 += moveY;
            part1.transform.localEulerAngles = position1;
        }
        else
        {
            part1.transform.localEulerAngles = to1;
        }
    }

    private void MoveToBottom()
    {
        if (Vector3.Distance(part7.transform.localEulerAngles, to7) > 1f)
        {
            position7 -= moveY;
            part7.transform.localEulerAngles = position7;
        }
        else
        {
            part7.transform.localEulerAngles = to7;
        }


        if (Vector3.Distance(part6.transform.localEulerAngles, to6) > 1f)
        {
            position6 -= moveZ;
            part6.transform.localEulerAngles = position6;
        }
        else
        {
            part6.transform.localEulerAngles = to6;
            boolTop = false;
        }


        if (Vector3.Distance(part5.transform.localEulerAngles, to5) > 1f)
        {
            position5 += moveY;
            part5.transform.localEulerAngles = position5;
        }
        else
        {
            part5.transform.localEulerAngles = to5;
        }


        if (Vector3.Distance(part4.transform.localEulerAngles, to4) > 1f)
        {
            position4 -= moveZ;
            part4.transform.localEulerAngles = position4;
        }
        else
        {
            part4.transform.localEulerAngles = to4;
        }


        if (Vector3.Distance(part3.transform.localEulerAngles, to3) > 1f)
        {
            position3 -= moveY;
            part3.transform.localEulerAngles = position3;
        }
        else
        {
            part3.transform.localEulerAngles = to3;
        }


        if (Vector3.Distance(part2.transform.localEulerAngles, to2) > 1f)
        {
            position2 += moveZ;
            part2.transform.localEulerAngles = position2;
        }
        else
        {
            part2.transform.localEulerAngles = to2;
        }


        if (Vector3.Distance(part1.transform.localEulerAngles, to1) > 1f)
        {
            position1 += moveY;
            part1.transform.localEulerAngles = position1;
        }
        else
        {
            part1.transform.localEulerAngles = to1;
        }
    }

    private void MoveToReturnHome()
    {
        if (Vector3.Distance(part7.transform.localEulerAngles, to7) > 1f)
        {
            position7 += moveY;
            part7.transform.localEulerAngles = position7;
        }
        else
        {
            part7.transform.localEulerAngles = to7;
        }


        if (Vector3.Distance(part6.transform.localEulerAngles, to6) > 1f)
        {
            position6 -= moveZ;
            part6.transform.localEulerAngles = position6;
        }
        else
        {
            part6.transform.localEulerAngles = to6;
        }


        if (Vector3.Distance(part5.transform.localEulerAngles, to5) > 1f)
        {
            position5 -= moveY;
            part5.transform.localEulerAngles = position5;
        }
        else
        {
            part5.transform.localEulerAngles = to5;
        }


        if (Vector3.Distance(part4.transform.localEulerAngles, to4) > 1f)
        {
            position4 += moveZ;
            part4.transform.localEulerAngles = position4;
        }
        else
        {
            part4.transform.localEulerAngles = to4;
        }


        if (Vector3.Distance(part3.transform.localEulerAngles, to3) > 1f)
        {
            position3 -= moveY;
            part3.transform.localEulerAngles = position3;
        }
        else
        {
            part3.transform.localEulerAngles = to3;
        }


        if (Vector3.Distance(part2.transform.localEulerAngles, to2) > 1f)
        {
            position2 += moveZ;
            part2.transform.localEulerAngles = position2;
        }
        else
        {
            part2.transform.localEulerAngles = to2;
        }


        if (Vector3.Distance(part1.transform.localEulerAngles, to1) > 1f)
        {
            position1 -= moveY;
            part1.transform.localEulerAngles = position1;
        }
        else
        {
            part1.transform.localEulerAngles = to1;
        }
    }

    #endregion
}



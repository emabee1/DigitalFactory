using System;
using UnityEngine;

public class AutoServus : MonoBehaviour
{
    #region initial Attributes
    public GameObject servus;
    private Vector3 output = new Vector3(0.44f, 0.853f, 1f);
    private Vector3 kuka = new Vector3(0.44f, 0.853f, 2.255f);
    private Vector3 mill = new Vector3(0.44f, 0.853f, 3.975f);
    private Vector3 store = new Vector3(0.44f, 0.853f, 6.223f);
    private bool boolToOutput = false;
    private bool boolToKuka = false;
    private bool boolToMill = false;
    private bool boolToStore = false;

    public GameObject box;
    private Vector3 left = new Vector3(-0.571f, 0.14f, 1.38292f);
    private Vector3 center = new Vector3(-0.571f, 0.14f, 0.572f);
    private Vector3 right = new Vector3(-0.571f, 0.14f, -0.2167f);
    private bool boolToLeft = false;
    private bool boolToCenter = false;
    private bool boolToRight = false;

    private bool positionChanged = false;
    private int position = 0;
    #endregion

    // Update is called once per frame
    void Update()
    {
        if (positionChanged)
        {
            switch (position)
            {
                case 0:
                    ToOutput();
                    break;
                case 1:
                    ToKuka();
                    break;
                case 2:
                    ToMill();
                    break;
                case 3:
                    ToStore();
                    break;
                default:
                    break;
            }
            positionChanged = false;
            print(position);
        }

        if (Input.GetKeyDown("p"))
        {
            ToOutput();
        }
        if (boolToOutput)
        {
            MoveToOutput();
        }

        if (Input.GetKeyDown("o"))
        {
            ToKuka();
        }
        if (boolToKuka)
        {
            MoveToKuka();
        }

        if (Input.GetKeyDown("i"))
        {
            ToMill();
        }
        if (boolToMill)
        {
            MoveToMill();
        }

        if (Input.GetKeyDown("u"))
        {
            ToStore();
        }
        if (boolToStore)
        {
            MoveToStore();
        }


        if (Input.GetKeyDown("z"))
        {
            ToCenter();
        }
        if (boolToCenter)
        {
            MoveToCenter();
        }

        if (Input.GetKeyDown("r"))
        {
            ToRight();
        }
        if (boolToRight)
        {
            MoveToRight();
        }


        if (Input.GetKeyDown("l"))
        {
            ToLeft();
        }
        if (boolToLeft)
        {
            MoveToLeft();
        }

    }

    public void ProcessServerInput(double value, int v)
    {
        if (v == 8)
        {
            position = (int)(value * 10) / 2;
            if (position > 3)
            {
                position /= position;
            }
            positionChanged = true;
        }
    }

    #region Methodes to set bool
    private void ToOutput()
    {
        boolToOutput = true;
        boolToKuka = false;
        boolToMill = false;
        boolToStore = false;
    }

    private void ToKuka()
    {
        boolToOutput = false;
        boolToKuka = true;
        boolToMill = false;
        boolToStore = false;
    }

    private void ToMill()
    {
        boolToOutput = false;
        boolToKuka = false;
        boolToMill = true;
        boolToStore = false;
    }

    private void ToStore()
    {
        boolToOutput = false;
        boolToKuka = false;
        boolToMill = false;
        boolToStore = true;
    }

    private void ToLeft()
    {
        boolToLeft = true;
        boolToCenter = false;
        boolToRight = false;
    }

    private void ToCenter()
    {
        boolToLeft = false;
        boolToCenter = true;
        boolToRight = false;
    }

    private void ToRight()
    {
        boolToLeft = false;
        boolToCenter = false;
        boolToRight = true;
    }
    #endregion

    #region Methodes to move Servus and Box
    private void MoveToOutput()
    {
        if (Vector3.Distance(servus.transform.position, output) > 0.01)
        {
            servus.transform.position = Vector3.Lerp(servus.transform.position, output, 0.1f);
        }
        else
        {
            servus.transform.position = output;
            boolToOutput = false;
            boolToLeft = true;
            boolToCenter = false;
            boolToRight = false;
        }
    }

    private void MoveToKuka()
    {
        if (Vector3.Distance(servus.transform.position, kuka) > 0.01)
        {
            servus.transform.position = Vector3.Lerp(servus.transform.position, kuka, 0.1f);
        }
        else
        {
            servus.transform.position = kuka;
            boolToKuka = false;
            boolToLeft = false;
            boolToCenter = false;
            boolToRight = true;
        }
    }

    private void MoveToMill()
    {
        if (Vector3.Distance(servus.transform.position, mill) > 0.01)
        {
            servus.transform.position = Vector3.Lerp(servus.transform.position, mill, 0.1f);
        }
        else
        {
            servus.transform.position = mill;
            boolToMill = false;
            boolToLeft = true;
            boolToCenter = false;
            boolToRight = false;
        }
    }

    private void MoveToStore()
    {
        if (Vector3.Distance(servus.transform.position, store) > 0.01)
        {
            servus.transform.position = Vector3.Lerp(servus.transform.position, store, 0.1f);
        }
        else
        {
            servus.transform.position = store;
            boolToStore = false;
            boolToLeft = false;
            boolToCenter = false;
            boolToRight = true;
        }
    }

    private void MoveToRight()
    {
        if (Vector3.Distance(box.transform.localPosition, right) > 0.01)
        {
            box.transform.localPosition = Vector3.Lerp(box.transform.localPosition, right, 0.1f);
        }
        else
        {
            box.transform.localPosition = right;
            boolToRight = false;
            boolToCenter = true;
        }
    }

    private void MoveToCenter()
    {
        if (Vector3.Distance(box.transform.localPosition, center) > 0.01)
        {
            box.transform.localPosition = Vector3.Lerp(box.transform.localPosition, center, 0.1f);
        }
        else
        {
            box.transform.localPosition = center;
            boolToCenter = false;
        }
    }

    private void MoveToLeft()
    {
        if (Vector3.Distance(box.transform.localPosition, left) > 0.01)
        {
            box.transform.localPosition = Vector3.Lerp(box.transform.localPosition, left, 0.1f);
        }
        else
        {
            box.transform.localPosition = left;
            boolToLeft = false;
            boolToCenter = true;
        }
    }
    #endregion
}

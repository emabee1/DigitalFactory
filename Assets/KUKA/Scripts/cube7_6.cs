﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube7_6 : MonoBehaviour
{
    public Vector3 rotation = new Vector3(0, 0, 1);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if ((!Input.GetKey(KeyCode.LeftAlt)) && Input.GetKey(KeyCode.Keypad7))
         {
            if (transform.localEulerAngles.z < 120 || transform.localEulerAngles.z >= 240)
            {
                transform.Rotate(rotation);
                //Debug.Log("Part7:" + transform.localEulerAngles);
            }
         }


        if ((!Input.GetKey(KeyCode.LeftAlt)) && Input.GetKey("7"))
        {
            if (transform.localEulerAngles.z <= 120 || transform.localEulerAngles.z > 240)
            {
                transform.Rotate(-rotation);
                //Debug.Log("Part7:" + transform.localEulerAngles);
            }
        }
    }
}

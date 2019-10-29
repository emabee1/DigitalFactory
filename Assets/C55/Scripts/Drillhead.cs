using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drillhead : MonoBehaviour
{
    public GameObject drillhead;
    Vector3 position = new Vector3(0, 0, 0);
    //Vector3 positionto = new Vector3(0, 0, 0);
    Vector3 movement = new Vector3(0, 0.005f, 0);
    //bool toTop = false;
    //bool toBottom = false;
    //bool toChance = false;

    // Start is called before the first frame update
    void Start()
    {
        position = drillhead.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Manual Movement of the Drillhead

        if ((!Input.GetKey(KeyCode.LeftShift)) && Input.GetKey("c"))
        {
            position += movement;
            drillhead.transform.position = position;
        }

        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey("c"))
        {
            position -= movement;
            drillhead.transform.position = position;
        }
        
        
        
        
        /*
         * AutoPositioning of the Drillhead
         *  
        if (Input.GetKeyDown("c"))
        {
            positionto = new Vector3(-2.223f, 1.5361f, 3.459f);
            toTop = true;
            toBottom = false;
            toChance = false;
        }
        if (toTop)
        {
            if(Vector3.Distance(position, positionto) > 0.01)
            {
                position += movement;
                drillhead.transform.position = position;
            }
            else
            {
                drillhead.transform.position = positionto;
            }
        }

        if (Input.GetKeyDown("b"))
        {
            positionto = new Vector3(-2.223f, 1.2742f, 3.459f);
            toTop = false;
            toBottom = true;
            toChance = false;
        }
        if (toBottom)
        {
            if (Vector3.Distance(position, positionto) > 0.01)
            {
                position -= movement;
                drillhead.transform.position = position;
                Debug.Log("toBottom: " + position);
            }
            else
            {
                drillhead.transform.position = positionto;
            }
        }

        if (Input.GetKeyDown("v"))
        {
            positionto = new Vector3(-2.223f, 1.3961f, 3.459f);
            toTop = false;
            toBottom = false;
            toChance = true;
        }
        if (toChance)
        {
            if (Vector3.Distance(position, positionto) > 0.01)
            {
                if(position.y < 1.4f)
                {
                    position += movement;
                    drillhead.transform.position = position;
                    Debug.Log("toChance: " + position);
                }
                else
                {
                    position -= movement;
                    drillhead.transform.position = position;
                }
                
            }
            else
            {
                drillhead.transform.position = positionto;
            }
        }
        */
    }
}

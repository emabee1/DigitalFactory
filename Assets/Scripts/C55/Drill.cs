using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drill : MonoBehaviour
{
    public GameObject drill;
    bool startdrill = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("."))
        {
            if (startdrill)
            {
                startdrill = false;
            }
            else
            {
                startdrill = true;
            }

        }
        if (startdrill)
        {
            drill.transform.Rotate(0, 1000, 0 * Time.deltaTime);
        }

    }
}

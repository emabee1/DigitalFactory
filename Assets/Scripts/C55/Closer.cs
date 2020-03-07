using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Closer : MonoBehaviour
{
    public GameObject backhold;
    Vector3 position = new Vector3(0, 0, 0);
    Vector3 movement = new Vector3(0.008f, 0, 0);


    // Start is called before the first frame update
    void Start()
    {
        position.x = backhold.transform.position.x;
        position.y = backhold.transform.position.y;
        position.z = backhold.transform.position.z;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("n"))
        {
            position.x = backhold.transform.position.x;
            position.y = backhold.transform.position.y;
            position.z = backhold.transform.position.z;
            position = position - movement;
            backhold.transform.position = position;
        }

        if (Input.GetKeyDown("m"))
        {
            position.x = backhold.transform.position.x;
            position.y = backhold.transform.position.y;
            position.z = backhold.transform.position.z;
            position = position + movement;
            backhold.transform.position = position;
        }
    }
}

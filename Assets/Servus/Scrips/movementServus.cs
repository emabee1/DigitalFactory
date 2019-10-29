using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementServus : MonoBehaviour
{
    public Rigidbody rb;
    public float Force = 2000f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, Force * Time.deltaTime, ForceMode.Impulse);
            Debug.Log(rb.position);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -Force * Time.deltaTime, ForceMode.Impulse);
            Debug.Log(rb.position);
        }
    }
}

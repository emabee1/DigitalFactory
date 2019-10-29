using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementCamera : MonoBehaviour
{

    public float speed = 200;
    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;
    private Vector3 previousPosition = new Vector3(0,0,0);
    private Quaternion previousRotation = new Quaternion(0, 0, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
        }

        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);


        if (Input.GetMouseButtonDown(0))
        {
            previousPosition = GameObject.Find("Main Camera").transform.position;
            previousRotation = GameObject.Find("Main Camera").transform.rotation;
            GameObject.Find("Main Camera").transform.position = new Vector3(-0.56f, 2.51f, 0.21f);
        }

        if (Input.GetMouseButtonDown(1))
        {
            GameObject.Find("Main Camera").transform.position = previousPosition;
            GameObject.Find("Main Camera").transform.rotation = previousRotation;
        }
    }
}

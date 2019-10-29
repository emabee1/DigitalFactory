using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frontcube8_7 : MonoBehaviour
{
    public Vector3 rotation = new Vector3(0, 1, 0);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftAlt) && Input.GetKey(KeyCode.Keypad8))
        {
            if (transform.localEulerAngles.y < 170 || transform.localEulerAngles.y >= 190)
            {
                transform.Rotate(rotation);
                Debug.Log("Part8: " + transform.localEulerAngles);
            }
        }
        if (Input.GetKey(KeyCode.LeftAlt) && Input.GetKey("8"))
        {
            if (transform.localEulerAngles.y <= 170 || transform.localEulerAngles.y > 190)
            {
                transform.Rotate(-rotation);
                Debug.Log("Part8: " + transform.localEulerAngles);
            }
        }
    }
}

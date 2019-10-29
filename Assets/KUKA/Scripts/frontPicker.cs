using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frontPicker : MonoBehaviour
{
    public Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftAlt) && Input.GetKey(KeyCode.Keypad2))
        {
            if (transform.localEulerAngles.y < 170 || transform.localEulerAngles.y >= 190)
            {
                transform.Rotate(position);
                Debug.Log("Part2:" + transform.localEulerAngles);
            }
        }
        if (Input.GetKey(KeyCode.LeftAlt) && Input.GetKey("2"))
        {
            if (transform.localEulerAngles.y <= 170 || transform.localEulerAngles.y > 190)
            {
                transform.Rotate(-position);
                Debug.Log("Part2:" + transform.localEulerAngles);
            }
        }
    }
}

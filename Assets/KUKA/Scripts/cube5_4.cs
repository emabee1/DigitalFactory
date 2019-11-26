using UnityEngine;

public class Cube5_4 : MonoBehaviour
{
    public Vector3 rotation = new Vector3(0, 0, 1);

    // Update is called once per frame
    void Update()
    {
        if ((!Input.GetKey(KeyCode.LeftAlt)) && Input.GetKey(KeyCode.Keypad5))
        {
            if (transform.localEulerAngles.z < 120 || transform.localEulerAngles.z >= 240)
            {
                transform.Rotate(rotation);
            }
        }

        if ((!Input.GetKey(KeyCode.LeftAlt)) && Input.GetKey("5"))
        {
            if (transform.localEulerAngles.z <= 120 || transform.localEulerAngles.z > 240)
            {
                transform.Rotate(-rotation);
            }
        }
    }
}

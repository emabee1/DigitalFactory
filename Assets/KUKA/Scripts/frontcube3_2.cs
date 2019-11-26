using UnityEngine;

public class Frontcube3_2 : MonoBehaviour
{
    public Vector3 rotation = new Vector3(0, 0, 1);

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftAlt) && Input.GetKey(KeyCode.Keypad3))
        {
            if (transform.localEulerAngles.z < 120 || transform.localEulerAngles.z >= 240)
            {
                transform.Rotate(rotation);
            }
        }

        if (Input.GetKey(KeyCode.LeftAlt) && Input.GetKey("3"))
        {
            if (transform.localEulerAngles.z <= 120 || transform.localEulerAngles.z > 240)
            {
                transform.Rotate(-rotation);
            }
        }

    }
}

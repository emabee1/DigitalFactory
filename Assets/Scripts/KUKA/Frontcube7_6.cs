using UnityEngine;

namespace KUKA
{

    public class Frontcube7_6 : MonoBehaviour
    {
        public Vector3 rotation = new Vector3(0, 0, 1);

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.LeftAlt) && Input.GetKey(KeyCode.Keypad7))
            {
                if (transform.localEulerAngles.z < 360 || transform.localEulerAngles.z >= 0)
                {
                    transform.Rotate(rotation);
                    print(transform.localEulerAngles);
                }
            }

            if (Input.GetKey(KeyCode.LeftAlt) && Input.GetKey("7"))
            {
                if (transform.localEulerAngles.z <= 360 || transform.localEulerAngles.z > 0)
                {
                    transform.Rotate(-rotation);
                    print(transform.localEulerAngles);
                }
            }
        }
    }
}

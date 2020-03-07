using UnityEngine;

namespace KUKA
{
    public class Frontcube2_1 : MonoBehaviour
    {
        public Vector3 rotation = new Vector3(0, 1, 0);

        // Update is called once per frame
        void Update()
        {

            if (Input.GetKey(KeyCode.LeftAlt) && Input.GetKey(KeyCode.Keypad2))
            {
                if (transform.localEulerAngles.y < 360 || transform.localEulerAngles.y >= 0)
                {
                    transform.Rotate(rotation);
                    print(transform.localEulerAngles);
                }
            }

            if (Input.GetKey(KeyCode.LeftAlt) && Input.GetKey("2"))
            {
                if (transform.localEulerAngles.y <= 360 || transform.localEulerAngles.y > 0)
                {
                    transform.Rotate(-rotation);
                    print(transform.localEulerAngles);
                }
            }
        }
    }
}

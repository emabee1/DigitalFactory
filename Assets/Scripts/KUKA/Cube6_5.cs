using UnityEngine;

namespace KUKA
{
    public class Cube6_5 : MonoBehaviour
    {
        public Vector3 rotation = new Vector3(0, 1, 0);

        // Update is called once per frame
        void Update()
        {
            if ((!Input.GetKey(KeyCode.LeftAlt)) && Input.GetKey(KeyCode.Keypad6))
            {
                if (transform.localEulerAngles.y < 170 || transform.localEulerAngles.y >= 190)
                {
                    transform.Rotate(rotation);
                }

            }

            if ((!Input.GetKey(KeyCode.LeftAlt)) && Input.GetKey("6"))
            {
                if (transform.localEulerAngles.y <= 170 || transform.localEulerAngles.y > 190)
                {
                    transform.Rotate(-rotation);
                }
            }
        }
    }
}

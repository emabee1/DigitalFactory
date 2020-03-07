using UnityEngine;

namespace C55
{
    public class Fronthold : MonoBehaviour
    {
        public GameObject fronthold;
        Vector3 position = new Vector3(0, 0, 0);
        Vector3 movement = new Vector3(0.005f, 0, 0);
        // Start is called before the first frame update
        void Start()
        {
            position.x = fronthold.transform.position.x;
            position.y = fronthold.transform.position.y;
            position.z = fronthold.transform.position.z;
        }

        // Update is called once per frame
        void Update()
        {
            //Manual Movement of the Fronthold

            if ((!Input.GetKey(KeyCode.LeftShift)) && Input.GetKey("b"))
            {
                position.x = fronthold.transform.position.x;
                position.y = fronthold.transform.position.y;
                position.z = fronthold.transform.position.z;
                position += movement;
                fronthold.transform.position = position;
            }

            if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey("b"))
            {
                position.x = fronthold.transform.position.x;
                position.y = fronthold.transform.position.y;
                position.z = fronthold.transform.position.z;
                position -= movement;
                fronthold.transform.position = position;
            }
        }
    }
}

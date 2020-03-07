using UnityEngine;

namespace C55
{
    public class Substruction : MonoBehaviour
    {
        public GameObject substruction;
        Vector3 position = new Vector3(0, 0, 0);
        Vector3 movement = new Vector3(0, 0, 0.005f);

        // Start is called before the first frame update
        void Start()
        {
            position = substruction.transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            //Manual Movement of the Substruction

            if ((!Input.GetKey(KeyCode.LeftShift)) && Input.GetKey("v"))
            {
                position += movement;
                substruction.transform.position = position;
            }

            if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey("v"))
            {
                position -= movement;
                substruction.transform.position = position;
            }
        }
    }
}

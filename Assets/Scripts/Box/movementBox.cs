using UnityEngine;

namespace Box
{
    public class MovementBox : MonoBehaviour
    {
        public float Force = 500f;
        public Rigidbody rb;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if (Input.GetKey("a"))
            {
                rb.AddForce(-Force * Time.deltaTime, 0, 0, ForceMode.Impulse);
            }
            if (Input.GetKey("d"))
            {
                rb.AddForce(Force * Time.deltaTime, 0, 0, ForceMode.Impulse);
            }
        }
    }
}

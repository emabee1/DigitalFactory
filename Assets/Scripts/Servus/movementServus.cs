using UnityEngine;

namespace Servus
{
    public class MovementServus : MonoBehaviour
    {
        public Rigidbody rb;
        public float Force = 2000f;

        // Update is called once per frame
        void FixedUpdate()
    
        {
            if (Input.GetKey("w"))
            {
                rb.AddForce(0, 0, Force * Time.deltaTime, ForceMode.Impulse);
                Debug.Log(rb.position);
            }
            if (Input.GetKey("s"))
            {
                rb.AddForce(0, 0, -Force * Time.deltaTime, ForceMode.Impulse);
                Debug.Log(rb.position);
            }
        }
    }
}

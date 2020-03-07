using UnityEngine;

namespace C55
{
    public class Magazine : MonoBehaviour
    {
        public GameObject magazine;
        Vector3 rotation = new Vector3(0, 0, 0);
        Vector3 movement = new Vector3(0, 1, 0);

        // Start is called before the first frame update
        void Start()
        {
            rotation = magazine.transform.localEulerAngles;
        }

        // Update is called once per frame
        void Update()
        {
            if ((!Input.GetKey(KeyCode.LeftShift)) && Input.GetKey(","))
            {
                rotation = rotation - movement;
                magazine.transform.localEulerAngles = rotation;
            }

            if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(","))
            {
                rotation = rotation + movement;
                magazine.transform.localEulerAngles = rotation;
            }

        }
    }
}

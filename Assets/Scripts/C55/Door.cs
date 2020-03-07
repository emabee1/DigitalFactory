using UnityEngine;

namespace C55
{
    public class Door : MonoBehaviour
    {
        public GameObject cube;

        Vector3 opened = new Vector3(0, 0f, 0);
        Vector3 closed = new Vector3(0, -80f, 0);

        Vector3 rotation = new Vector3(0, 0, 0);

        Vector3 movement = new Vector3(0, 1, 0);

        private bool open = false;
        private bool close = false;


        // Start is called before the first frame update
        void Start()
        {
            rotation = cube.transform.localEulerAngles;
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown("y"))
            {
                close = true;
                open = false;
            }

            if (close)
            {
                if (Vector3.Distance(rotation, closed) > 1)
                {
                    rotation -= movement;
                    cube.transform.localEulerAngles = rotation;
                    if (rotation == new Vector3(0, 0, 0))
                    {
                        rotation = new Vector3(0, 360f, 0);
                    }
                }
                else
                {
                    cube.transform.localEulerAngles = closed;
                    close = false;
                }

            }

            if (Input.GetKeyDown("x"))
            {
                close = false;
                open = true;
            }

            if (open)
            {
                if (Vector3.Distance(rotation, opened) > 1)
                {
                    rotation += movement;
                    cube.transform.localEulerAngles = rotation;
                    if (rotation.y >= 360)
                    {
                        rotation = new Vector3(0, 0, 0);
                    }
                }
                else
                {
                    cube.transform.localEulerAngles = opened;
                    open = false;
                }

            }
        }
    }
}

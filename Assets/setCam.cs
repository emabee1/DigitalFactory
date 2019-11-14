using UnityEngine;

public class setCam : MonoBehaviour
{
    void OnMouseDown()
    {
        GameObject.Find("Main Camera").transform.position = new Vector3(-1.13f, 3.81f, -0.62f);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

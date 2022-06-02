using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS_Camara : MonoBehaviour
{
    public Camera FPS_Camera;

    public float horizontalSpeed;
    public float verticalSpeed;

    float h;
    float v;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        h = horizontalSpeed * Input.GetAxis("Mouse X");
        v = verticalSpeed * Input.GetAxis("Mouse Y");

        transform.Rotate(0, h, 0);
        FPS_Camera.transform.Rotate(-v, 0, 0);
    }
}

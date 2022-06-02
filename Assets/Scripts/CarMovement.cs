using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarMovement : MonoBehaviour
{
    public float movementSpeed;
    public float rotationSpeed;
    public float jumpForce;
    public int maxJumps;

    public int OriginalPos;

    public Camera FPS_Camera;

    public float horizontalSpeed;
    public float verticalSpeed;

    float h;
    float v;

    int hasJump;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {

        hasJump = maxJumps;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        h = horizontalSpeed * Input.GetAxis("Mouse X");
        v = verticalSpeed * Input.GetAxis("Mouse Y");

        transform.Rotate(0, h, 0);
        FPS_Camera.transform.Rotate(-v, 0, 0);

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, movementSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -movementSpeed);
        }
        if (Input.GetKey(KeyCode.D) && hasJump == maxJumps)
        {
            transform.Rotate(0, rotationSpeed, 0);
        }
        if (Input.GetKey(KeyCode.A) && hasJump == maxJumps)
        {
            transform.Rotate(0, -rotationSpeed, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space) && hasJump > 0)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            hasJump--;
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "ground")
        {
            hasJump = maxJumps;
        }

        if (col.gameObject.name == "DeathWall")
        {
            Destroy(gameObject);
        }
        if (col.gameObject.name == "DeathWall")
        {
            transform.position = new Vector3(0, OriginalPos, 0);
        }
        if (col.gameObject.name == "DeathFloor")
        {
            transform.position = new Vector3(0, OriginalPos, 0);
        }
    }
       
    
}

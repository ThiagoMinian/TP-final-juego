using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarMovement : MonoBehaviour
{
    float movementSpeed = 0.09f;
    float rotationSpeed = 3;
    public float jumpForce = 1;
    public int maxJumps = 1;
    float Tiempo = 0;

    int hasJump;
    Rigidbody rb;

    Vector3 posicionInicial;


    // Start is called before the first frame update
    void Start()
    {
        hasJump = maxJumps;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > Tiempo + 5)
        {
            int total = Mathf.FloorToInt(Time.time);

            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(0, 0, movementSpeed);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(0, 0, -movementSpeed);
            }
            if (Input.GetKey(KeyCode.RightArrow) && hasJump == maxJumps)
            {
                transform.Rotate(0, rotationSpeed, 0);
            }
            if (Input.GetKey(KeyCode.LeftArrow) && hasJump == maxJumps)
            {
                transform.Rotate(0, -rotationSpeed, 0);
            }
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Salida"))
        {
            Debug.Log("Felicidades, ganaste");
        }
        else if (col.CompareTag("Enemigo"))
        {
            rb.MovePosition(posicionInicial);
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}

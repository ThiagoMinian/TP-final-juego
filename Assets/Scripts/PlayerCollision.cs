using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Enemigo")
        {
            transform.position = new Vector3(10, 0.4f, -22);
        }
        if (collision.gameObject.name == "Salida")
        {
            SceneManager.LoadScene("Ganaste");
        } 
    }
}

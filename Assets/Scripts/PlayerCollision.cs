using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public GameObject cubePrefab;
    public int cantidaddeIns;
    GameObject clone;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Enemigo")
        {
            transform.position = new Vector3(10, 0.4f, -22);
            SceneManager.LoadScene("Perdiste");
        }
        if (collision.gameObject.name == "Wall")
        {
            transform.position = new Vector3(10, 0.4f, -22);
            SceneManager.LoadScene("Perdiste");
        }
        if (collision.gameObject.name == "Salida")
        {
            SceneManager.LoadScene("Ganaste");
            for (int counter = 1; counter < cantidaddeIns; counter++)
            {
                clone = Instantiate(cubePrefab);
                Destroy(clone, 3);

            }
        } 
    }
}

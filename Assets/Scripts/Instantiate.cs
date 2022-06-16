using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public GameObject cubePrefab, clone;
    public float i = 6;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            while (i > 0)
            {
                i--;
                clone = Instantiate(cubePrefab, transform.position, Quaternion.identity);
                Destroy(clone, 3);
            }

        }
    }
}

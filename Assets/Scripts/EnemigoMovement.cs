﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoMovement : MonoBehaviour
{
    GameObject mygameobject;
    float rotar = 2.5f;
    Vector3 myvector3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, rotar, 0));
    }
}

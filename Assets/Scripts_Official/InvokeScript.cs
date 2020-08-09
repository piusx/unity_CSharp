﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeScript : MonoBehaviour
{
    public GameObject target;


    void Start()
    {
        Invoke("SpawnObject", 2);
        InvokeRepeating("SpawnObject", 2, 1);

        //CancelInvoke();
    }

    void SpawnObject()
    {
        float x = Random.Range(-2.0f, 2.0f);
        float z = Random.Range(-2.0f, 2.0f);
        Instantiate(target, new Vector3(x, 2, z), Quaternion.identity);
        //Instantiate(target, new Vector3(0, 2, 0), Quaternion.identity);
    }
}

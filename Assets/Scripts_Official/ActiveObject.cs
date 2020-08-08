using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveObject : MonoBehaviour
{

    void Start()
    {
        gameObject.SetActive(false);
    }

    void Update()
    {
        if(!gameObject)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test9 : MonoBehaviour
{
    int[] exp = { 50, 100, 200, 300, 500, 600, 700 };

    void Start()
    {
        for (int i = 0; i <= exp.Length; i++)
        {
            print(exp[i]);
        }
    }
}

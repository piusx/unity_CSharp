using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test8 : MonoBehaviour
{
    //1차원 배열
    int[] exp = { 50, 100, 200, 300, 400, 500 };

    int[] array = new int[10];

    //2차원 배열
    int[,] array2 = { { 1, 2, 3, 4, 5 }, { 10, 20, 30, 40, 50 } };


    void Start()
    {
        //exp[5] = 600;
        //print(exp[5]);

        for (int i = 0; i < exp.Length; i++)
        {
            print(exp[i]);
        }
    }

}

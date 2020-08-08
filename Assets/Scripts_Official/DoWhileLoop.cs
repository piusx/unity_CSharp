using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 최소한 한번은 실행후 상태를 체크 
public class DoWhileLoop : MonoBehaviour
{

    void Start()
    {
        bool shouldContinue = false;

        do
        {
            print("Hello World");
        } 
        while (shouldContinue == true);
    }
}

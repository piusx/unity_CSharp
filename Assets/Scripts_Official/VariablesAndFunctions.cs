using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 함수와 변수
public class VariablesAndFunctions : MonoBehaviour
{ 

    int myInt = 10;

    void Start()
    {
        myInt = MultiplyByTwo(myInt); // int 변수 적용
        Debug.Log(myInt);
    }

    int MultiplyByTwo(int number) // int값을 반환
    {
        int result;
        result = number * 2;
        return result;
    }
}

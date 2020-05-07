using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex01_Variavle : MonoBehaviour
{
    // 1+x= 101
    // 숫자 1- 상수
    // x 변수
    int x = 100; //변수 선언
    int y = 100;
    int sum; 

    void Start()
    {
        //print(x); x 출력

        sum = x + y;
        print(sum);
        print(-sum);
    }

    void Update()
    {

    }
}

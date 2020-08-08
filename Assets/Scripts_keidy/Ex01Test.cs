using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex01Test : MonoBehaviour
{
    // 변수
    // 1 + x =  101
    // 숫자 1 -  상수
    // x - 변수
    // 변수의 값을 계속 바꿀수 있다.
    int x = 100;
    int y = 100;
    int sum;

    void Start()
    {
        //x = -500; 우항의 값이 좌항에 대입
        //print(x);

        sum = x + y; // 변수와 변수간의 계산이가능 
        print(sum);
        print(-sum);
    }

    void Update()
    {
        
    }
}

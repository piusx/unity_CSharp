using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test5 : MonoBehaviour
{
    // 기본 연산자 +,-,*,/,%(대입연산자)
    // ++, -- 증감 연산자 전위[선 연산 코드 실행], 후위[선 코드 실행 후 연산]
    // 관계 연산자 == <= >= < > !=
    // 놀리 연산자 && || !
    // 비트 연산자

    int a = 10;
    int b = 10;
    bool c = false;

    void Start()
    {
        //a += b;  // 복합대입 연산자
        //c++; // ++c
        //print(++c);
        //print(c++);
        //print(c);

        //c = (a > b);  // 관계 연산자
        //c = (a != b) || (a == b);  // 논리 연산자 && (And - 모든 조건이 참일 경우에만 True) || (OR - 조건중에 하나라도 True면 True)
        // false            true

        c = !(a == b);

        print(c);
    }
}

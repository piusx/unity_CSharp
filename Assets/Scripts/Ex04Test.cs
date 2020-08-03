using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2
{
    private int aa;
    public int bb;
    public static int cc; // 공공의 공유 자원, 정적 변수
}

public class Ex04Test : MonoBehaviour
{
    int a = 5; // 멤버 변수, 전역 변수

    Test2  aaa;

    Test2 a01 = new Test2();
    Test2 a02 = new Test2();
    Test2 a03 = new Test2();

    private int f = 5;
    public int g  = 5;

    void AAA()
    {
        aaa.bb = 10; 
    }


    void ABC()
    {
        int a = 5; // 지역 변수 . 우선순위 높다

        a = 6;

        int b = 5; // 지역 변수

        print(b);
    }

    void ABC2()
    {
        int b = 10; // 지역 변수

        print(b);
    }

    void ABC3(float _parameter) // 매개변수
    {

    }
}

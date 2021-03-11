using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestD1
{
    private int a;
    public int b;
    public static int c; // 공공의 공유자원.

}


public class Test4 : MonoBehaviour
{

    TestD1 a1 = new TestD1();
    TestD1 a2 = new TestD1();
    TestD1 a3 = new TestD1();

    void Start()
    {
        ABC();
    }

    void ABC()
    {
        a1.b = 5;
        a2.b = 1;
        a3.b = 10;

        TestD1.c = 100;

        print(a1.b);
        print(a2.b);
        print(a3.b);
        print(TestD1.c);
    }
}

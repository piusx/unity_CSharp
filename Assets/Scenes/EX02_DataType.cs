using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX02_DataType : MonoBehaviour
{
    //long a = 40000;
    // sbyte 정수 자료형 (-128~ + 127) - 1바이트
    // short 정수 자료형 (-3만~ +3만) - 2바이트
    // integer 정수 자료형 (-20억~ +20억) - 4바이트
    // long 정수 자료형 - 8바이트

    //float f = 4.001f; 
    //double d = 4.000001;
    //decimal m = 4.000001m;
    // 실수 자료

    //string s = "테스트 asdasf";
    //char c = 'a'; // 유니코드 등/
    // 문자 입력

    int a = 100;
    float b = 100.15f;
    string c;

    int sum;
    float sum2;

    void Start()
    {
        sum = (int)(a + b); //캐스트 강제 형변환 (int)
        sum2 = a + b;

        print(sum);
        print(sum2);

        c = a.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex02Test : MonoBehaviour
{
    int a = 100;
    float b = 100.15f;
    string cc;
    int aa;
    string dd = "100";

    float sum2;
    int sum;

    // byte 정수 자료형 (0~255)
    // sbyte 정수 자료형 ( -128 ~ +127) 1바이트
    // short 정수 자료형 ( -3만 ~ +3만 )  - 2바이트
    // integer 정수 자료형 ( -20억 ~ +20억 ) - 4바이트
    // long 정수 자료형 ( 최대한 크기) - 8바이트

    float f = 4.000001f;
    double d = 4.00001;
    decimal m = 4.000001m;

    // float 실수 자료형 
    // double 실수 자료형
    // decimal 실수 자료형

    string s = "문자";
    char c = 'A';  // unicode 한글자만 기록

    void Start()
    {
        sum = (int)(a + b); // 캐스트 강제 형변환. 소수점 절삭
        sum2 = a + b;

        print(sum2);
        print(sum);


        cc = a.ToString();
        print(cc + "string");

        aa = int.Parse(dd); // int로 강제 형변환
        print(dd+"int");
        

    }

    void Update()
    {
        
    }
}

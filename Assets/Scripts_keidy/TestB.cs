using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestB : MonoBehaviour
{

    int a;
    //float b = 100.014f;
    string b ="100";

    int sum;
    float sum2;

    // sbyte 정수 자료형 (-127 ~ +127) 1바이트
    // short 정수 자료형 (-3만 ~ +3만) 2바이트 
    // integer 정수 자료형(-20억 ~ +20억) 4바이트
    // long 정수 자료형 8바이트 

    //float f = 4.01f;
    //double d = 4.00001;
    //decimal m = 4.0000012m;

    // flaot  실수 자료형
    // double 실수 자료형
    // deciamal 실수 자료형

    //string s = "문자 정보 ";
    //char g = 'A'; // 0065

    void Start()
    {
        a = int.Parse(b);   // string에서 int 변환
        //b = a.ToString(); // int에서 strong 변환


        print(a);
    }

    void Update()
    {
        
    }
}

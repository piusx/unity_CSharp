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

    // sbyte ���� �ڷ��� (-127 ~ +127) 1����Ʈ
    // short ���� �ڷ��� (-3�� ~ +3��) 2����Ʈ 
    // integer ���� �ڷ���(-20�� ~ +20��) 4����Ʈ
    // long ���� �ڷ��� 8����Ʈ 

    //float f = 4.01f;
    //double d = 4.00001;
    //decimal m = 4.0000012m;

    // flaot  �Ǽ� �ڷ���
    // double �Ǽ� �ڷ���
    // deciamal �Ǽ� �ڷ���

    //string s = "���� ���� ";
    //char g = 'A'; // 0065

    void Start()
    {
        a = int.Parse(b);   // string���� int ��ȯ
        //b = a.ToString(); // int���� strong ��ȯ


        print(a);
    }

    void Update()
    {
        
    }
}

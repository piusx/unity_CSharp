using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test7 : MonoBehaviour
{
    int num = 0;

    string text = "�����ٶ󸶹ٻ�";
    /*
    void Start()
    {
        for (int i = 0; i <= 10; i++)
        {
            num = i;
            print(num);
        }
    }
    
    void Start()
    {
        for (;;)
        {
            num ++;

            if (num % 2 == 0)
                continue; // �ش� ȸ���� ����. ���� ȸ�� ����.

            print(num);

            if (num > 10)
                break; // ù��° �ݺ���, ���ǹ� Ż��
        }
    }
    */


    // for��(�ݺ�Ƚ���� ��Ȯ�Ҷ�) �� while �� ( �ݺ� Ƚ���� ��Ȯ���� ������)

    /*
    void Start()
    {
        while (num < 10)
        {
            num++;
            if (num > 10)
                break;

            print(num);
        }
    }
    
    
    void Start()
    {
        do    // ������ 1ȸ���� ���� 
        {
            num++;
            print(num);
        }
        while (num < 10);
    }

    */

    void Start()
    {
        foreach(char a in text)
        {
            print(a);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test7 : MonoBehaviour
{
    int num = 0;

    string text = "가나다라마바사";
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
                continue; // 해당 회차를 끝냄. 다음 회차 시작.

            print(num);

            if (num > 10)
                break; // 첫번째 반복문, 조건문 탈출
        }
    }
    */


    // for문(반복횟수가 명확할때) 과 while 문 ( 반복 횟수가 명확하지 않을때)

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
        do    // 무조건 1회차는 실행 
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

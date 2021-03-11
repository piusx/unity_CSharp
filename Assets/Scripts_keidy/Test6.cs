using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test6 : MonoBehaviour
{  
    int input = 10;
    //int string input = "가나다";
    int num = 10;

    bool result;
    /*
    // 조건 분기문
    void Start()
    {
        //result = input > num;

        if (input == num)
        {
            print("input 값이 num과 같습니다");
        }
        else if (input == num)
        {
            print("input 값이 num보다 큽니다");
        }
        else if (input == num)
        {
            print("input 값이 num보다 작습니다");
        }
        else
        {
            print("그밖에 경우");
        }
    }

    void Start()
    {
        switch (input)
        {
            case 10:
                print("input의 값이 10입니다.");
                break;
            case 11:
                print("input의 값이 11입니다.");
                break;
            case 12:
                print("input의 값이 12입니다.");
                break;
            default:
                print("그 외의 경우");
                break;
        }
    }
    */

    void Start()
    {
        int temp = input == num ? 50 : 100; // 삼항 연산자

        print(temp);
    }
}

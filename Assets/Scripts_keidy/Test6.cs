using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test6 : MonoBehaviour
{  
    int input = 10;
    //int string input = "������";
    int num = 10;

    bool result;
    /*
    // ���� �б⹮
    void Start()
    {
        //result = input > num;

        if (input == num)
        {
            print("input ���� num�� �����ϴ�");
        }
        else if (input == num)
        {
            print("input ���� num���� Ů�ϴ�");
        }
        else if (input == num)
        {
            print("input ���� num���� �۽��ϴ�");
        }
        else
        {
            print("�׹ۿ� ���");
        }
    }

    void Start()
    {
        switch (input)
        {
            case 10:
                print("input�� ���� 10�Դϴ�.");
                break;
            case 11:
                print("input�� ���� 11�Դϴ�.");
                break;
            case 12:
                print("input�� ���� 12�Դϴ�.");
                break;
            default:
                print("�� ���� ���");
                break;
        }
    }
    */

    void Start()
    {
        int temp = input == num ? 50 : 100; // ���� ������

        print(temp);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test5 : MonoBehaviour
{
    // �⺻ ������ +,-,*,/,%(���Կ�����)
    // ++, -- ���� ������ ����[�� ���� �ڵ� ����], ����[�� �ڵ� ���� �� ����]
    // ���� ������ == <= >= < > !=
    // � ������ && || !
    // ��Ʈ ������

    int a = 10;
    int b = 10;
    bool c = false;

    void Start()
    {
        //a += b;  // ���մ��� ������
        //c++; // ++c
        //print(++c);
        //print(c++);
        //print(c);

        //c = (a > b);  // ���� ������
        //c = (a != b) || (a == b);  // �� ������ && (And - ��� ������ ���� ��쿡�� True) || (OR - �����߿� �ϳ��� True�� True)
        // false            true

        c = !(a == b);

        print(c);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test9 : MonoBehaviour
{
    //�迭
    int[] exp = new int[5] { 1, 2, 3, 4, 5 };

    // ArrayList
    ArrayList arrayList = new ArrayList();

    //List
    List<int> list = new List<int>();

    //HashTable
    Hashtable hashTable = new Hashtable();

    /*
    void Start()
    {
        arrayList.Add(1);
        arrayList.Add(2);
        arrayList.Add(3);
        arrayList.Add("������");
        arrayList.Add(4.5);

        //print(arrayList.Count);
        //arrayList.Remove("������"); // ���ϴ� �ε����� ����
        //arrayList.RemoveAt(3);  // ���° �ε����� ���� 
        //arrayList.RemoveRange(1, 1);  //1���� ��� ����� ����
        //arrayList.Clear(); // �ʱ�ȭ
        //arrayList.Contains("������"); //������ Ʈ��

        for (int i = 0; i < arrayList.Count; i++)
        {
            print(arrayList[i]);
        }
    }
    */

    void Start()
    {
        hashTable.Add("��", 10000);
        hashTable.Add("�鸸", 10000);

        print(hashTable["��"]);
    }

}

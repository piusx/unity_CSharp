using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test9 : MonoBehaviour
{
    //배열
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
        arrayList.Add("가나다");
        arrayList.Add(4.5);

        //print(arrayList.Count);
        //arrayList.Remove("가나다"); // 원하는 인덱스를 삭제
        //arrayList.RemoveAt(3);  // 몇번째 인덱스를 삭제 
        //arrayList.RemoveRange(1, 1);  //1부터 몇개를 지울까 결정
        //arrayList.Clear(); // 초기화
        //arrayList.Contains("가나다"); //있으면 트루

        for (int i = 0; i < arrayList.Count; i++)
        {
            print(arrayList[i]);
        }
    }
    */

    void Start()
    {
        hashTable.Add("만", 10000);
        hashTable.Add("백만", 10000);

        print(hashTable["만"]);
    }

}

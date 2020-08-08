using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 조건이 넘으면 실행을 멈춘다 
public class ForLoop : MonoBehaviour
{
    int numEnemies = 3;

    void Start()
    {
        for (int i = 0; i < numEnemies; i++)
        {
            Debug.Log("몬스터가 생성됨:" + i);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeAndStart : MonoBehaviour
{
    void Awake()
    {  // Reference between scripts, initialization
        // 인스펙터창에서 스크립트요소를 비활성화 해도 실행된다.
        // 스크립트와 초기화 사이의 모든 레퍼런스 설정에 이용
        //Debug.Log("Awake called.");
    }

    void Start()
    {  // Once script component is enabled
        // Awake다음으로 첫 업데이트 직전에 호출되지만 스크립트 요소가 황성화 상태여야한다.
        Debug.Log("Start called.");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateAndFixedUpdate : MonoBehaviour
{
    private float fixedUpdateTimer;
    private float updateTimer;

    private void LateUpdate()
    {

    }

    private void OnMouseUpAsButton()
    {

    }



    void Start()
        // Called every physics step  물리단계 호출
        // FixedUpdate interveals are consistent 일관성 있는 호출 간격
        // Used for regular updates such as; 다음과 같은 정기 업데이트에 사용
        // Adjusting physics (Rigidbody) objects 물리 객체 조정 
    {
        Debug.Log("FixedUpdate time :" + Time.deltaTime);
    }

    void Update()
        // Called every frame  모든 프레임에서 호출 
        // Used for regular updates such as: 다음과 같은 정기 업데이트에 사용 
        // Moving non-physics objects  비물리 개체 이동
        // Simple Timers 단순 타이머 
        // Receving Input 입력받기

        // Update interval times vary 업데이트 간격 시간은 다양
    {
        Debug.Log("Update time :" + Time.deltaTime);
    }
}

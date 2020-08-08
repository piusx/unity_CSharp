using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// WhileLoop 단순히 작업을 수행하는데 사용
public class WhileLoop : MonoBehaviour
{
    int cupInTheSink = 4;

    void Start()
    {
        while (cupInTheSink > 0)
        {
            Debug.Log("나는 컵을 닦았다!");
            cupInTheSink--;
        }
    }
}

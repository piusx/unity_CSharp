using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX_Coroutine : MonoBehaviour
{
    //Coroutine myCoroutine1;
    private IEnumerator myCoroutine1;

    void Start()
    {

        //myCoroutine1 = StartCoroutine(LoopA());
        myCoroutine1 = LoopA();
        StartCoroutine("LoopB"); // 오버헤드될수 있음 
        StartCoroutine(Stoop()); // 코루틴 정지 방법 

    }

    IEnumerator LoopA()
    {
        for (int i = 0; i < 100; i++)
        {
            print("i의 값 = " + i);

            yield return new WaitForSeconds(1f);
        }
    }

    IEnumerator LoopB()
    {
        for (int x = 0; x < 100; x++)
        {
            print("x의 값 = " + x);
            yield return new WaitForSeconds(1f);
        }
    }

    IEnumerator Stoop()
    {
        yield return new WaitForSeconds(2f);
        //StopCoroutine(myCoroutine1);
        StopAllCoroutines();
        yield return new WaitForSeconds(2f);
        StopCoroutine("LoopB");
    }
}

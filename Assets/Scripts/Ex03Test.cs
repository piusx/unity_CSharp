using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex03Test : MonoBehaviour
{
    int intValue;

    float floatValue = 10.5f;
    float floatValue2 = 200.5f;


    void FloatToInt(float _parameter, float _parameter2, string _stringParm) // 괄호안에 입력받을 함수
    { // void 함수의 처리 결화에 반환값(int)이 없을때
        intValue = (int)(_parameter + _parameter2); // 강제 형변환 
        print(intValue);
        print(_stringParm);
    }

    int FloatToInts(float _parameter, float _parameter2)
    {
        return (int)(_parameter + _parameter2);
    }

    void Start()
    {
        FloatToInt(floatValue, floatValue2, "테스트");
        print(FloatToInts(floatValue, floatValue2));
    }

    void Update()
    {
        
    }
}

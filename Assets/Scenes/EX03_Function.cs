using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX03_Function : MonoBehaviour
{   // 함수 void 함수의 처리결과에 반환값이 없을때 사용
    // 강제형 변환 
    int intValue;

    float floatValue = 10.5f;
    float floatValue2 = 20.5f;
    /*
    void FloatToInt(float _parameter, float _parameter2, string _stringParm = "디플트값")
    {
        //intValue = (int)floatValue;  // 강제 형변환
        intValue = (int)(_parameter + _parameter2);
        print(intValue);
        print(_stringParm);

    }
    */

    int FloatToInt(float _parameter, float _parameter2)
    {
        return Multiply((int)(_parameter + _parameter2));
    }

    int Multiply(int _parameter)
    {
        return _parameter * _parameter;
    }


    void Start()
    {
        print(FloatToInt(floatValue, floatValue2)); // 함수 실행. string 변수값 미입력시 디폴트값 출력가능
    }
    
    void Update()
    {
        
    }
}

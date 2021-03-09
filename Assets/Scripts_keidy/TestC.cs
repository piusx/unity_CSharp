using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestC : MonoBehaviour
{

    int intValue;
    int intValue3;

    float floatValue = 10.5f;
    float floatValue2 = 110.5f;


    void FloatToInt(float _parameter, float _parameter2, string _stringParm = "디폴트값")
    {
        intValue = (int)(_parameter + _parameter2);
        print(intValue);
        print(_stringParm);
    }

    void FloatToInt2(float _parameter)
    {
        intValue = (int)_parameter;
        print(intValue);
    }

    void Start()
    {
        //FloatToInt(floatValue, floatValue2, "테스트");
        //intValue3= FloatToInt3(floatValue, floatValue2);
        //print(intValue3);
        //FloatToInt(floatValue, floatValue2);
        //FloatToInt2(floatValue);
    }

    void Update()
    {
        
    }
}

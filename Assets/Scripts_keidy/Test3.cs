using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test3 : MonoBehaviour
{

    int intValue;
    int intValue3;

    float floatValue = 10.5f;
    float floatValue2 = 110.5f;


    void FloatToInt(float _parameter, float _parameter2, string _stringParm = "����Ʈ��")
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

    int Multiply(int _parameter)
    {
        return _parameter * _parameter;
    }

    void Start()
    {
        //FloatToInt(floatValue, floatValue2, "�׽�Ʈ");
        FloatToInt(floatValue, floatValue2);
        //intValue3= FloatToInt3(floatValue, floatValue2);
        //print(intValue3);
        //FloatToInt2(floatValue);
    }

    void Update()
    {
        
    }
}

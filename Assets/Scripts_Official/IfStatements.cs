using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TemperatureTest();
        }

            coffeeTemperature -= Time.deltaTime * 5f;
    }

    void TemperatureTest()
    {
        if(coffeeTemperature > hotLimitTemperature)
        {
            print("커피가 너무 뜨겁다");
        }
        else if(coffeeTemperature < coldLimitTemperature)
        {
            print("커피가 너무 차겁다");
        }
        else
        {
            print("커피마시기 적당하다.");
        }
    }
}

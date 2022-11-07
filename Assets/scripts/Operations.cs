using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operations : MonoBehaviour
{
    public int x = 7;
    public int y = 4;
    private int result;
   
    private void Start()
    {
        //suma
        result = x + y;
        Debug.Log(result);
        //resta
        result = x - y;
        Debug.Log(result);
        //multiplicacion
        result = x * y;
        Debug.Log(result);
        //division
        result = x / y;
        Debug.Log(result);
        //modulo
        result = x % y;
        Debug.Log(result);

    }

    private void Calculator(float num1, float num2)  //FUNCIONES (input)
    {
        Debug.Log($"Sum:{num1} + {num2} = {num1 + num2}");
        Debug.Log($"Sum:{num1} - {num2} = {num1 - num2}");
        Debug.Log($"Sum:{num1} * {num2} = {num1 * num2}");
        Debug.Log($"Sum:{num1} / {num2} = {num1 / num2}");
    }
}


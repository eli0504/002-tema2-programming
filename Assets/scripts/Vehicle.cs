using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    [SerializeField] private int wheels = 4; // saves the number of the vehicle's wheels 
    [SerializeField] private string name = "car";

    [SerializeField] private bool isOn;

    public string sound;

    private void Start()
    {
        Debug.Log($"{name} tiene {wheels} ruedas");
        if (isOn == true)
        {
            Debug.Log($"El veh�culo {name} est� encendido");
        }
        else
        {
            Debug.Log($"El veh�culo {name} est� apagado");
        }

        if (isOn == false)
        {
            Debug.Log($"El veh�culo {name} est� apagado");
        }
        else if (sound != "")
        {
            Debug.Log($"El veh�culo {name} est� encendido y hace {sound}");
        }
        else
        {
            Debug.Log($"El veh�culo {name} est� en marcha");
        }

    }



}

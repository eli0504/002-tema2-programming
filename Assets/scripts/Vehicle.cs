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
            Debug.Log($"El vehículo {name} está encendido");
        }
        else
        {
            Debug.Log($"El vehículo {name} está apagado");
        }

        if (isOn == false)
        {
            Debug.Log($"El vehículo {name} está apagado");
        }
        else if (sound != "")
        {
            Debug.Log($"El vehículo {name} está encendido y hace {sound}");
        }
        else
        {
            Debug.Log($"El vehículo {name} está en marcha");
        }

    }



}

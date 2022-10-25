using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    [SerializeField] private int wheels = 4; // saves the number of the vehicle's wheels 
    [SerializeField] private string name = "car";

    [SerializeField] private bool isOn;

    [SerializeField] private float gasoline;

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
            Debug.Log($"El vehículo {name} está apagado"); //if else
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
            Debug.Log($"El vehículo {name} está en marcha"); //else if
        }


        if (isOn == true)
        {
            Debug.Log($"El vehículo {name} está en marcha");
            if (gasoline < 10)
            {
                Debug.Log($"El vehículo {name} no tiene gasolina"); //las dos condiciones son verdaderas (anidados II)
            }
            else
            {
                Debug.Log($"¡A {name} le queda gasolina suficiente!"); //convertimos en falso la con2
            }
        }
        else
        {
            Debug.Log("La condición1 es falsa y la condición2 me da igual");
        }

       if (gasoline<10 && isOn == true)
        {
            Debug.Log($"A {name} le queda poca gasolina!"); //operador AND II (las dos cond. son verdad)
        }
    }



}

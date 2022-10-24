using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirtsScript : MonoBehaviour
{
    /* 
     4 variables with the player information 
    */

    // This variable saves the player's ages
    public int playerAge = 33;
    public float playerSpeed = 3.125f;
    public string playerName = "Eli Caparros";
    public bool gameOver = false;
    public string message = "Hola mundo";
    public int points = 256;
    public bool isRaining;
    public int number = 5;
    private void Start()
    {
        Debug.Log(message);
        Debug.Log(points);
        Debug.Log($"Tengo {points} puntos");
     

        Debug.Log(string.Format("Tengo {0} puntos", points));
        Debug.Log(string.Format("Hola {0}, tienes {1} puntos", playerName, points));

        if (isRaining == true)
        {
            Debug.Log("Recuerda coger el paraguas");
        }


        if (number > 0)
        {
            Debug.Log($"El numero {number} es positivo");
        }
        else
        {
            Debug.Log("El número {number} es negativo o cero");        }
        }


}


  

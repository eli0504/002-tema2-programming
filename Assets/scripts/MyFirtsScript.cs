using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirtsScript : MonoBehaviour
{
    /* 
     4 variables with the player information 
    */

    public int playerAge = 33;
    public float playerSpeed = 3.125f;
    public string playerName = "Eli Caparros";
    public bool gameOver = false;
    public string message = "Hola mundo";
    public int points = 256;
    public bool isRaining;
    public int number = 5;
    public bool canGetBigger = true;
    public Vector3 initialPos = new Vector3(1, 1, 1); //posicion objeto

    private void Start()
    {
        Debug.Log(message);
        Debug.Log(points);
        Debug.Log($"Tengo {points} puntos");


        Debug.Log(string.Format("Tengo {0} puntos", points));
        Debug.Log(string.Format("Hola {0}, tienes {1} puntos", playerName, points));

        Debug.Log(transform.position);


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
            Debug.Log("El número {number} es negativo o cero"); }



        transform.position = initialPos;
    }

    private void Update()    //fuera del Start y se ejecuta constantemente
    {
        if (Input.GetMouseButtonDown(0))  //cada vez que de click, el cubo sube (vector.up)
        {
            transform.position += Vector3.up;
        }

        if (canGetBigger == true)  //es verdad que puede hacerse mas grande
        {
           if (Input.GetMouseButtonDown (0)) {
                transform.localScale += Vector3.one;  // este tipo de vector aumenta en todas las escalas (vector.one)
            }
        }

       
     

    }
}




        




  

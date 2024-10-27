using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    void Start()
    {

        // Variables 
        int number1 = 5, number2 = 3;
        string name = "Mohammed Al-Shawwa";

        // Output
        Debug.Log("My Name: " + name);
        Debug.Log("Result: " + number1 + " + " + number2 + " = " + (number1 + number2));
        Debug.Log("Result: " + number1 + " - " + number2 + " = " + (number1 - number2));
        Debug.Log("Result: " + number1 + " * " + number2 + " = " + (number1 * number2));
        Debug.Log("Result: " + number1 + " / " + number2 + " = " + (number1 / number2));

        Debug.Log("---------------------------------------");

        Debug.LogWarning("This is Warning Log");
        Debug.LogError("This is Error Log");

    }
    
}

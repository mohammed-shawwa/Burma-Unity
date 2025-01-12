using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assignment35
{
    public class BuiltInDelegatesExample : MonoBehaviour
    {
        Action logMessage;
        Func<int, int> square;
        Predicate<int> isEven;

        void Start()
        {
            logMessage = () => Debug.Log("Hello from Action delegate!");
            logMessage();

            square = (number) => (int)Mathf.Pow(number, 2);
            Debug.Log($"Square: {square(5)}");

            isEven = (number) => number % 2 == 0;
            Debug.Log($"Is 4 even? {isEven(4)}");


        }

    }
}

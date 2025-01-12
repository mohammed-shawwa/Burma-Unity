using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assignment35
{

    delegate void MathOperation(int number);

    public class MulticastDelegateExample : MonoBehaviour
    {
        MathOperation mathOperation;

        void Start()
        {
            mathOperation += DoubleNumber;
            mathOperation += SquareNumber;
            mathOperation += CubeNumber;

            mathOperation?.Invoke(5);
        }

        void DoubleNumber(int number)
        {
            Debug.Log($"Double: {number * 2}");
        }

        void SquareNumber(int number)
        {
            Debug.Log($"Square: {number * number}");
        }

        void CubeNumber(int number)
        {
            Debug.Log($"Cube: {Mathf.Pow(number, 3)}");
        }
    }
}

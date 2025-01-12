using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assignment35
{
    public class ListMethodsExample : MonoBehaviour
    {
        List<int> numbers = new List<int> { 3, 1, 4, 1, 5, 9 };

        void Start()
        {
            numbers.Sort((a, b) => b.CompareTo(a));

            Debug.Log(string.Join(", ", numbers));

        }


    }
}

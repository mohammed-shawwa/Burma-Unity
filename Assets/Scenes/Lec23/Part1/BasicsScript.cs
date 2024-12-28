using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{

    public class BasicScript : MonoBehaviour
    {

        void Start()
        {
            var number = 10;
            var result = "Hi";
            var checker = true;

            checker = number % 2 == 0;
            result = checker ? "even" : "odd";
            Debug.Log($"The number {number} is {result}");

            Debug.Log($"The current data time: {DateTime.Now}");
            Debug.Log($"The current time: {DateTime.Now.TimeOfDay}");
            Debug.Log($"The current day as string: {DateTime.Now.DayOfWeek}");

        }


    }
}
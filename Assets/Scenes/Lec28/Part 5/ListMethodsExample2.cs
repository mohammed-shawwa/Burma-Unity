using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assignment35
{
    public class ListMethodsExample2 : MonoBehaviour
    {

        List<int> numbers2 = new List<int> { 3, 1, 4, 1, 5, 9, 2, 6 };
        void Start()
        {
            List<int> filterNumbers = numbers2.FindAll((number) =>
            {
                return number % 2 == 0;
            });

            Debug.Log(string.Join(", ", filterNumbers));
        }

    }
}

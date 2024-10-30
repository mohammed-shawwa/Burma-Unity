using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment10 : MonoBehaviour
{

    void Start()
    {
        int tableNumber = 5;
        for (int n2 = 1; n2 <= 10; n2++)
        {
            Debug.Log(tableNumber + " x " + n2 + " = " + Multiply(tableNumber, n2));
        }
    }

    int Multiply(int n1, int n2)
    {
        return n1 * n2;
    }
}

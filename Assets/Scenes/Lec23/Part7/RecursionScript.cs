using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
    public class RecursionScript : MonoBehaviour
    {
        void Start()
        {
            int n1 = 10;
            int n2 = 30;

            Debug.Log("Fibonacci by use (Recursive) for n1 = " + n1 + ": " + FibonacciRecursive(n1));
            Debug.Log("Fibonacci by use (Recursive) for n2 = " + n2 + ": " + FibonacciRecursive(n2));


            Debug.Log("Fibonacci by use (Iterative) for n1 = " + n1 + ": " + FibonacciIterative(n1));
            Debug.Log("Fibonacci by use (Iterative) for n2 = " + n2 + ": " + FibonacciIterative(n2));


        }

        int FibonacciRecursive(int n)
        {
            if (n <= 1)
                return n;
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        int FibonacciIterative(int n)
        {
            if (n <= 1)
                return n;

            int val1 = 0, val2 = 1, current = 0;

            for (int i = 2; i <= n; i++)
            {
                current = val1 + val2;
                val1 = val2;
                val2 = current;
            }

            return current;
        }

    }
}
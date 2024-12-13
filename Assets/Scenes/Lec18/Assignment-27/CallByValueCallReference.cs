using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment27
{
    public class CallByValueAndReference : MonoBehaviour
    {
        void Start()
        {
            int a = 2, b = 3, c;

            Debug.Log($"Value of a: {a}");
            CallByValue(a);
            Debug.Log($"Value of a after CallByValue call: {a}");

            Debug.Log($"Value of b: {b}");
            CallByReference(ref b);
            Debug.Log($"Value of b after CallByReference call: {b}");

            UsingOut(out c);
            Debug.Log($"Value of c after UsingOut call: {c}");

        }


        void CallByValue(int x)
        {
            x += 10;
        }

        void CallByReference(ref int x)
        {
            x += 10;
        }

        void UsingOut(out int x)
        {
            x = 100;
        }

    }
}
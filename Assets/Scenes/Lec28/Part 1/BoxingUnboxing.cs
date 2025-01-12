using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment35
{

    public class BoxingUnboxing : MonoBehaviour
    {

        void Start()
        {
            int health = 100;
            object boxingHealth = health;

            int unboxingHealth = (int)boxingHealth;
            unboxingHealth -= Random.Range(1, 99);

            Debug.Log($"Original int value: {health}");
            Debug.Log($"Boxed value: {boxingHealth}");
            Debug.Log($"Unboxed and modified value: {unboxingHealth}");

        }

    }

}
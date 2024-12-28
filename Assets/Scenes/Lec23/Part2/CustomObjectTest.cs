using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
    public class CustomObjectTest : MonoBehaviour
    {

        void Start()
        {
            CustomObject customObject1 = new CustomObject(1, "Mohammed");
            print(customObject1.ToString());

            CustomObject customObject2 = new CustomObject(1, "Mohammed");
            print(customObject2.ToString());

            print("Obj1 is equal Obj2 : " + customObject1.Equals(customObject2));

        }

    }
}
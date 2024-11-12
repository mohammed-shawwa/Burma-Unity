using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
    public class Position
    {
        public float x, y, z;

        public Position(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void printPosition()
        {
            Debug.Log("(X: " + x + " , Y: " + y + " , Z: " + z + ")");
        }

        public string ToString()
        {
            return "(X: " + x + " , Y: " + y + " , Z: " + z + ")";
        }

    }

}
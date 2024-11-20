using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lec13
{
    public class RotateScript : MonoBehaviour
    {
        public float startAfterSecond = 1;
        private float startAfterSecondTemp = 0;

        public float speed = 90;
        void Start()
        {

        }

        void Update()
        {
            if (startAfterSecond < startAfterSecondTemp)
            {
                transform.Rotate(new Vector3(speed, 0, 0) * Time.deltaTime);
            }
            else
            {
                startAfterSecondTemp += Time.deltaTime;
            }
        }
    }
}

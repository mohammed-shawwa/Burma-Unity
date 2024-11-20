using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lec13
{
    public class PlayerMovement : MonoBehaviour
    {
        public float speed = 10;
        public float rotateSpeed = 10;

        public GameObject rightLegGameObject;
        public GameObject leftLegGameObject;

        public GameObject rightHandGameObject;
        public GameObject leftHandGameObject;

        public float timeLegMove = 0.2f;
        private float timeLegMoveTemp = 0;

        private bool isRightLegMove = true;

        void Start()
        {

        }

        void Update()
        {

            float v = Input.GetAxis("Vertical");
            Vector3 temp = transform.position;
            temp.z += v * speed * Time.deltaTime;
            transform.position = temp;

            if (v != 0)
            {

                if (timeLegMoveTemp > timeLegMove)
                {
                    if (isRightLegMove)
                    {
                        rightLegGameObject.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, -25f));
                        rightHandGameObject.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, -90f));

                        leftLegGameObject.transform.localRotation = Quaternion.Euler(Vector3.zero);
                        leftHandGameObject.transform.localRotation = Quaternion.Euler(Vector3.zero);
                    }
                    else
                    {
                        leftLegGameObject.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, -25f));
                        leftHandGameObject.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, -90f));

                        rightLegGameObject.transform.localRotation = Quaternion.Euler(Vector3.zero);
                        rightHandGameObject.transform.localRotation = Quaternion.Euler(Vector3.zero);

                    }

                    isRightLegMove = !isRightLegMove;
                    timeLegMoveTemp = 0;
                }

                timeLegMoveTemp += Time.deltaTime;

            }
            else
            {
                rightLegGameObject.transform.localRotation = Quaternion.Euler(Vector3.zero);
                rightHandGameObject.transform.localRotation = Quaternion.Euler(Vector3.zero);

                leftLegGameObject.transform.localRotation = Quaternion.Euler(Vector3.zero);
                leftHandGameObject.transform.localRotation = Quaternion.Euler(Vector3.zero);
            }


            transform.localRotation = Quaternion.Euler(
                new Vector3(
                    transform.localRotation.eulerAngles.x,
                    transform.localRotation.eulerAngles.y + (Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime),
                    transform.localRotation.eulerAngles.z
                    )
                );
        }
    }
}
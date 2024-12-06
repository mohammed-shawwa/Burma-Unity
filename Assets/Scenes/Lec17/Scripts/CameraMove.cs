using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lec17
{
    public class CameraMove : MonoBehaviour
    {
        public Transform book;

        public float speed = 5f;

        void Start()
        {

        }

        void Update()
        {
            TranslateCamera();
            LookAtToBook();
        }

        private void TranslateCamera()
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            transform.Translate(new Vector3(h, 0, v) * speed * Time.deltaTime);
        }

        private void LookAtToBook()
        {
            transform.LookAt(book);
        }
    }

}
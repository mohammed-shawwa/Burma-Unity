using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment37
{


    public class RigidBodyCharacterController : MonoBehaviour
    {

        public float speed = 5.0f;
        public float jumpForce = 5.0f;

        public float highSpeed = 10.0f;
        Rigidbody _rg;

        Vector3 moveInput;

        bool isJump;

        void Awake()
        {
            _rg = GetComponent<Rigidbody>();
        }

        void Start()
        {
            _rg.mass = 5f;
            _rg.freezeRotation = true;
        }

        void Update()
        {
            float x = Input.GetAxisRaw("Horizontal");
            float z = Input.GetAxisRaw("Vertical");
            float tempSpeed = speed;

            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
            {
                tempSpeed = highSpeed;
            }


            moveInput = new Vector3(x, 0, z);
            moveInput = moveInput.normalized * tempSpeed;
            moveInput.y = _rg.velocity.y;

            if (Input.GetButtonDown("Jump") && Mathf.Abs(_rg.velocity.y) < 0.01f)
            {
                isJump = true;
            }

        }

        void FixedUpdate()
        {

            _rg.velocity = moveInput;

            if (isJump)
            {
                _rg.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                isJump = false;
            }

        }
    }

}
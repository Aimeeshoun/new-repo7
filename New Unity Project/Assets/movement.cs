
using UnityEngine;

public class movement : MonoBehaviour
{
    
       public CharacterController characterController;

        public float thespeed = 5.0f;
        public float jumpSpeed = 9.81f;
        public float gravity = 25.0f;

        private Vector3 moveDirection = Vector3.zero;

        void Start()
        {
            characterController = GetComponent<CharacterController>();
        }

        void Update()
        {
            if (characterController.isGrounded)
            {
              

                moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
                moveDirection *= thespeed;

                if (Input.GetKeyDown(KeyCode.RightShift))
                {
                    moveDirection.y = jumpSpeed;
                }
            }

            moveDirection.y -= gravity * Time.deltaTime;

            characterController.Move(moveDirection * Time.deltaTime);
        }
    }



using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class Movement3d : MonoBehaviour

{

    public CharacterController theController;

    public float theRunSpeed = 40f;

    private float horizontalMove = 0f;

    private bool theJump = false;



    private Vector3 thePosition;

    public float theMoveSpeed = 11f, gravity = 9.81f, jumpSpeed = 29f;

    private int theJumpCount;

    public int theJumpCountMax = 2;



    void Start()

    {

        theController = GetComponent<CharacterController>();

    }



    void Update()

    {

        theController.Move(thePosition * Time.deltaTime);





        thePosition.x = theMoveSpeed * Input.GetAxis("Horizontal");

        thePosition.y -= gravity;



        if (theController.isGrounded)

        {





            thePosition.y = 0f;





            theJumpCount = 0;





            if (Input.GetButtonDown("Jump") && theJumpCount < theJumpCountMax)

            {

                thePosition.y = jumpSpeed;

                theJumpCount++;

            }

            horizontalMove = Input.GetAxis("Horizontal") * theRunSpeed;


        }
    }
}
    


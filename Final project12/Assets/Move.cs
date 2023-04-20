using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public class Move : MonoBehaviour
    {

        public float moveSpeed;
        public float Jumpforce;
        public Transform ceilingCheck;
        public Transform groundCheck;
        public LayerMask groundObject;
        public float checkRadius;
        public int maxJumpCount;


        private Rigidbody2D rb;
        private float moveDirection;
        private bool facingRight;
        private bool isJumping = false;
        private bool isGrounded;
        private int jumpcount;


        private void Start()
        {
            jumpcount = maxJumpCount;
            moveSpeed = 15;

        }

        private void Awake()
        {

            rb = GetComponent<Rigidbody2D>();

        }


        void Update()
        {
            ProcessInputs();

            Animate();




        }


        private void FixedUpdate()
        {
            move();
            isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, groundObject);
            if (isGrounded)
            {

                jumpcount = maxJumpCount;


            }
        }


        private void move()

        {
            rb.velocity = new Vector2(moveDirection * moveSpeed, rb.velocity.y);

            if (isJumping)
            {
                rb.AddForce(new Vector2(0f, Jumpforce));
                jumpcount--;
            }
            isJumping = false;
        }


        private void Animate()

        {
            if (moveDirection > 0 && !facingRight)
            {
                FlipCharacter();
            }
            else if (moveDirection < 0 && facingRight)
            {
                FlipCharacter();
            }

        }

        private void ProcessInputs()
        {
            moveDirection = Input.GetAxis("Horizontal");

            if (Input.GetButtonDown("Jump") && jumpcount > 0)
            {
                isJumping = true;
            }


        }

        private void FlipCharacter()
        {
            facingRight = !facingRight;
            transform.Rotate(0f, 180f, 0f);
        }

    }

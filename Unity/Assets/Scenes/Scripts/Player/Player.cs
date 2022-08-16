using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpForce = 500f;
    Rigidbody2D rb;

    float dirX;
    float moveSpeed = 10f;
    bool jumpBtnPressed = false;
    bool isGrounded = true;
    

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        if (Input.GetButtonDown("Jump") && isGrounded) 
        {
            jumpBtnPressed = true;        
        }
    }


    void FixedUpdate()
    {
        rb.velocity = new Vector2 (moveSpeed * dirX, rb.velocity.y);

        if(jumpBtnPressed)
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            jumpBtnPressed = false;
            isGrounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
    }
    
}

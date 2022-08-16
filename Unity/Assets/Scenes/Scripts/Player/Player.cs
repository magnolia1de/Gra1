using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;

    float dirX, dirY;
    float moveSpeed = 10f;
    

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        dirX = Input.GetAxis("Horizontal");
        dirY = Input.GetAxis("Vertical");
    }


    void FixedUpdate()
    {
        rb.velocity = moveSpeed * new Vector2 (dirX, dirY);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float moveSpeed = 3f;
    public Rigidbody2D rb;
    Vector2 movement;
    public Animator animator;
    public bool isAlive = true;

    // Update is called once per frame
    void Update()
    {
        //input
        movement.x = (int)Input.GetAxisRaw("Horizontal");
        movement.y = (int)Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }
    
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //death
        if (collision.gameObject.layer == 9)
        {
            Debug.Log("ded");
        }
        //win
        else if (collision.gameObject.layer == 10)
        {
            Debug.Log("win");
        }
    }
}

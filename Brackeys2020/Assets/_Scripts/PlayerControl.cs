using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    public float moveSpeed = 3f;
    public Rigidbody2D rb;
    Vector2 movement;
    public Animator animator;
    public bool isAlive = true;
    public float timePowerLeft = 100f;
    public static bool timePowerActive = false;

    public Text timeTxt;

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
        if (Input.GetKey(KeyCode.Space) && timePowerLeft > 0)
        {
            timePowerActive = true;
            timePowerLeft -= 0.30f;
            timeTxt.text = Mathf.Round(timePowerLeft).ToString() + "%";
        }
        else
        {
            timePowerActive = false;
        }
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
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


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{

    public float speed;
    public float time;
    public bool moveRight;
    public bool moveHori = true;
    bool onPlatform = false;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time = Time.deltaTime;

        if (PlayerControl.timePowerActive)
        {
            time = -time;
        }
        if (moveHori == true)
        {
            if (moveRight)
            {
                transform.Translate(2 * time * speed, 0, 0);
            }
            else
            {
                transform.Translate(-2 * time * speed, 0, 0);
            }
        }
        else
        {
            if (moveRight)
            {
                transform.Translate(0, 2 * time * speed, 0);
            }
            else
            {
                transform.Translate(0, -2 * time * speed, 0);
                
            }
        }
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            //collision.transform.SetParent(transform);
        }

        if (collision.gameObject.CompareTag("Platform1"))
        {
            if (moveRight)
            {
                moveRight = false;
            }
            else
            {
                moveRight = true;
            }
        }
        
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        //collision.transform.SetParent(null);
    }

}

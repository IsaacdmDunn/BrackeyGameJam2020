using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{

    public float speed;
    public float time;
    public bool moveRight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time = Time.deltaTime;

        if (PlayerControl.timePowerActive)
        {
            time = -time;
        }
        if (moveRight)
        {
            transform.Translate(2 * time * speed, 0, 0);
        }
        else
        {
            transform.Translate(-2 * time * speed, 0, 0);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            Debug.Log("platform");
            collision.transform.SetParent(transform);
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

    private void OnTriggerExit2D(Collider2D collision)
    {
        collision.transform.SetParent(null);
    }
}

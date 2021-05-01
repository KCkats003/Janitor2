using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public float jumpForce;
    public bool died;
    public int collected; 

    // Start is called before the first frame update
    void Start()
    {
        collected = 0; 
        died = false; 
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      
        Move();
    }

    void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        float movexBy = x * speed;
        float moveyBy = y * speed;
        rb.velocity = new Vector2(movexBy, moveyBy);
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

    
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("You mopped up the blood");
        if (collision.gameObject.tag == "Blood")
        {
            //  gameObject.active = false;
            collected = collected + 1; 
            collision.gameObject.SetActive(false);
            Debug.Log("You mopped up the blood");
        }
        if (collision.gameObject.tag == "Brick")
        {

            Debug.Log("You hit a brick and died");
            died = true;
        }
    }
    /*
     void OnTriggerEnter2D(Collision2D collision)
    {
        Debug.Log("You mopped up the blood");
        if (collision.gameObject..tag == "Blood")
            // gameObject.active = false;
            collision.gameObject.SetActive(false);
    }
    */

}

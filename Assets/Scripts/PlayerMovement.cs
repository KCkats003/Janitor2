using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool touchFish = false;
    
    Rigidbody2D rb;
    public float speed;
    public float jumpForce;
    public bool died;
    public int collected;
    Animator animator;
    public BoxCollider2D Collider1;

    public GameObject shield;

    // Start is called before the first frame update
    void Start()
    {
        collected = 0;
        touchFish = false;
        died = false;
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        shield.SetActive(false);
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
        if (collision.collider == Collider1) {

            Debug.Log("You mopped up the blood");
            if (collision.gameObject.tag == "Blood")
            {
                //  gameObject.active = false;

                collision.gameObject.SetActive(false);
                Debug.Log("You mopped up the blood");
            }
            if (collision.gameObject.tag == "Brick")
            {

                Debug.Log("You hit a brick and died");
                died = true;
            }

        }

    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Blood")
        {
            if (touchFish == true)
            {
                touchFish = false;
            }
        }

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("You mopped up the blood");
        if (collision.gameObject.tag == "Blood")
        {
            collision.gameObject.SetActive(false);
            if (touchFish == false)
            {

                touchFish = true;
            }
        }
        // gameObject.active = false;
       
        Debug.Log("CCCCCCCCCCCC");
        Debug.Log(collected);

    }


    // Update is called once per frame
    void Update()
    {
        
        if (touchFish == true)
        {
            collected = collected + 1;
            touchFish = false;
        }
        Move();

        void Move()
        {
            float x = Input.GetAxisRaw("Horizontal");
            float y = Input.GetAxisRaw("Vertical");

            if (x == 0)
            {
                Debug.Log("Move");
                animator.SetBool("middleWalk", true);
                animator.SetBool("leftWalk", false);
                animator.SetBool("rightWalk", false);
            }
            else if (x > 0)
            {
                animator.SetBool("rightWalk", true);
                animator.SetBool("leftWalk", false);
                animator.SetBool("middleWalk", false);
            }
            else if (x < 0)
            {
                animator.SetBool("rightWalk", false);
                animator.SetBool("leftWalk", true);
                animator.SetBool("middleWalk", false);
            }

            float movexBy = x * speed;
            float moveyBy = y * speed;
            rb.velocity = new Vector2(movexBy, moveyBy);
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            shield.SetActive(true);
        }

    }
}

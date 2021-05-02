using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blood : MonoBehaviour
{
    public AudioSource cleansound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("You mopped up the blood");
       
        if (collision.gameObject.tag == "Player")
        {
            cleansound.Play();
            gameObject.active = false;
            gameObject.SetActive(false);
            //  gameObject.active = false;
            //   collision.gameObject.SetActive(false);
            Debug.Log("You mopped up the blood BLOOD");
        }
    }

   void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("You mopped up the blood");
       
        if (other.tag == "Player") {
            cleansound.Play();
            // gameObject.active = false;
            //    other.gameObject.SetActive(false);
            gameObject.active = false;
            gameObject.SetActive(false);

        }
            
    }
    
}

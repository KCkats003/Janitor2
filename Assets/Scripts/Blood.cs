using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blood : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //  gameObject.active = false;
            collision.gameObject.SetActive(false);
            Debug.Log("You mopped up the blood BLOOD");
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            // gameObject.active = false;
            other.gameObject.SetActive(false);
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroInGame : MonoBehaviour
{
   // public GameObject hero;
  //  public GameObject villian;
    private Rigidbody2D rb;
 //   private Rigidbody2D villianrb;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Starting2");
        //  InvokeRepeating("Move", 2.0f, 3.0f);
        //  yield WaitForSeconds(0.25);
        StartCoroutine(MyCoroutine());
        //   herorb = hero.gameObject.GetComponent<Rigidbody2D>();
        //   villianrb = villianrb.gameObject.GetComponent<Rigidbody2D>();
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        //this did not work
        //herorb = hero.AddComponent<Rigidbody2D>();
        //villianrb = villianrb.AddComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       

    }

    private void Move() {
        //transform.up * thrust
        //  hero.GetComponent<Rigidbody2D>().AddForce(0, 1, 0);
        // villian.GetComponent<Rigidbody2D>().AddForce(0, 1, 0);
        //    herorb.AddForce(transform.up * 1.0f);
        //   villianrb.AddForce(transform.up * 1.0f);
        rb.AddForce(transform.up * 200.0f);
    }

    IEnumerator MyCoroutine()
    {
        //This is a coroutine


        //yield return 0;    //Wait one frame
        yield return new WaitForSeconds(0.5f);
        Move();
    }

  
}

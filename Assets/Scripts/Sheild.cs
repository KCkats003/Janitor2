using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheild : MonoBehaviour
{
    Vector3 myVector;
    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        // transform.position = GameObject.Find("Player").transform.position;
        myVector = GameObject.Find("Player").transform.position;
        myVector = myVector + new Vector3(0.0f, 10.0f, 0.0f);

        transform.position = myVector;
    }
}

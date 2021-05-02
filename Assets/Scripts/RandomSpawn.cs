using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    
    // Random position will be the position we want to place the object
    Vector2 randomPosition;
    public float xRange = 3f;
    // xRange the range in the x axis that the object can be placed
    public float yRange = 3f;
    // yRange the range in the y axis that the object can be placed


    //time 
    //  private float nextActionTime = 0.0f;
    // public float period = 0.1f;
    private float nextActionTime = 3f;
    public float period = 3f;

    //prefab to keep spawning
    public GameObject BloodPrefab;
    public float radius = 1; 

    // Start is called before the first frame update
    void Start()
    {

        /*
        // xPosition and yPosition are set to random values with the ranges
        float xPosition = Random.Range(0 - xRange, 0 + xRange);
        float yPosition = Random.Range(0 - yRange, 0 + yRange);
        // randomPosition is then given values xPosition and yPosition, making it a random vector
        randomPosition = new Vector2(xPosition, yPosition);
        // randomPosition now describes a random position for our object, so it is then moved to it.
        transform.position = randomPosition;
        // now the object has been moved, completeting the process of placing it in a random position
        */
        // nextActionTime = 0.0f;
        InvokeRepeating("SpawnObjectsAtRandom", 2.0f, 3.0f);
    }

    private void Update()
    {
        
          if (Time.time > nextActionTime)
          {
              nextActionTime += period;
              // execute block of code here
            //  SpawnObjectsAtRandom();
          }
         
        /*
        if (Input.GetKeyDown("space"))
        {
            SpawnObjectsAtRandom();
        }
        */
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space key was pressed.");
            SpawnObjectsAtRandom();
        }
    }

    void SpawnObjectsAtRandom() {
        // Vector3 randomPos = Random.insideUnitCircle * radius; 
        // Instantiate(BloodPrefab, randomPos, Quaternion.identity);
        //xyz
        var position = new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(0.5f, -5.0f), 0);
        Instantiate(BloodPrefab, position, Quaternion.identity);
       
    }

    //Draw a circle so we know where the shit is 
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(this.transform.position, radius); 
    }

}
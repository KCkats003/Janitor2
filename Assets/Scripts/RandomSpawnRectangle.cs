using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnRectangle : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;

    void Start()
    {
        InvokeRepeating("SpawnObjectsAtRandom", 2.0f, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObjectsAtRandom()
    {
        var position = new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(10.0f, 15.0f), 0);
        Instantiate(prefab, position, Quaternion.identity);

    }


    }

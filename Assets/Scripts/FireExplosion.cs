using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireExplosion : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;

    void Start()
    {
        InvokeRepeating("SpawnObjectsAtRandom", 0.0f, 10.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnObjectsAtRandom()
    {
        var position = new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(10.0f, 15.0f), 0);
        var position2 = new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(10.0f, 15.0f), 0);
        var position3 = new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(10.0f, 15.0f), 0);
        var position4 = new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(10.0f, 15.0f), 0);

        Instantiate(prefab, position, Quaternion.identity);
        Instantiate(prefab, position2, Quaternion.identity);
        Instantiate(prefab, position3, Quaternion.identity);
        Instantiate(prefab, position4, Quaternion.identity);

    }

}

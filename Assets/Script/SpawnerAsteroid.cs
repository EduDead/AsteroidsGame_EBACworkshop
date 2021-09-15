using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerAsteroid : MonoBehaviour
{
    public GameObject prefabAsteroid;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)){
            Instantiate(prefabAsteroid, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SairOutroLado : MonoBehaviour
{
    int way;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    void OnBecameInvisible()
    {
        if (way == 0){
            transform.position = new Vector2(transform.position.x, -transform.position.y);
        }
        if (way == 1){
            transform.position = new Vector2(transform.position.x, -transform.position.y);
        }
        if (way == 1){
            transform.position = new Vector2(-transform.position.x, transform.position.y);
        }
        if (way == 0){
            transform.position = new Vector2(-transform.position.x, transform.position.y);
        }
    }
}

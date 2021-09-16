using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OndaDeAsteroide : MonoBehaviour
{
    public Asteroide prefabAsteroide;
    public int quantosAsteroides = 3;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < quantosAsteroides; i++){
            float x = Random.Range(-10.4f, 10.4f);
            float y = Random.Range(-4.0f, 4.0f);
            Vector3 posicao = new Vector3(x, y, 0.0f);
            Instantiate(prefabAsteroide, posicao, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

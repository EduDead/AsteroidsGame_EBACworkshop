using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroide : MonoBehaviour
{
    public static System.Action AsteroideDestruido = null;
    
    public Rigidbody2D meuRigidBody;
    public float velocidadeMaxima = 1.0f;
    public GameObject prefabExplosao2;

    public GameObject prefabAsteroideP;
    public int quantidadeFragmentos = 3;

     void Start()
    {
        Vector2 direcao = Random.insideUnitCircle;
        direcao *= velocidadeMaxima;
        meuRigidBody.velocity = direcao;
    }

    void OnTriggerEnter2D(Collider2D outro)
    {
        for(int i = 0; i < quantidadeFragmentos; i++){
            Instantiate(prefabAsteroideP, meuRigidBody.position, Quaternion.identity);
        }
        Instantiate(prefabExplosao2, meuRigidBody.position, Quaternion.identity);
        if(AsteroideDestruido != null){
            AsteroideDestruido();
        }
        Destroy(gameObject);
        Destroy(outro.gameObject);
    }
}
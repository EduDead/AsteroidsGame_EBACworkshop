using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SairOutroLado : MonoBehaviour
{
    const float Margem = 0.5f;
    public Rigidbody2D meuRigidbody;
    void Update(){
        Camera camera = GameplayCamera.instancia.minhaCamera;

        var maxX = camera.orthographicSize * camera.aspect;
        var maxY = camera.orthographicSize;

        float limiteEsquerda = -maxX;
        float limiteDireita = maxX;
        float limiteCima = maxY;
        float limiteBaixo = -maxY;

        Vector2 pos = meuRigidbody.position;
        if (meuRigidbody.position.x < limiteEsquerda - Margem){
            pos.x = limiteDireita + Margem;
        } else if (meuRigidbody.position.x > limiteDireita + Margem){
            pos.x = limiteEsquerda - Margem;
        }
        if (meuRigidbody.position.y < limiteBaixo - Margem){
            pos.y = limiteCima + Margem;
        } else if (meuRigidbody.position.y > limiteCima + Margem){
            pos.y = limiteBaixo - Margem;
        }
        meuRigidbody.position = pos;
    }
}

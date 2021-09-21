using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InterfacePontuacao : MonoBehaviour
{
    public TMP_Text textoPontuacao;
    public int pontuacao;

    void Awake(){
        textoPontuacao.text = "";
        Asteroide.AsteroideDestruido += AsteroideFoiDestruido;
    }
    void OnDestroy(){
        Asteroide.AsteroideDestruido -= AsteroideFoiDestruido;
    }

    void AsteroideFoiDestruido(){
        pontuacao += 100;
        AtualizaTextoPontuacao();
    }

    void AtualizaTextoPontuacao(){
        textoPontuacao.text = pontuacao.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfeitosAsteroides : MonoBehaviour
{
    public AudioSource meuAudioSource;
    public ParticleSystem particulaAsteroide;
    void Start()
    {
        meuAudioSource.Play();
        particulaAsteroide.Play(false);
    }

    
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessMusicController : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        audioSource.volume = GlobalGM.Instance.endlessMusicVolume;
        audioSource.Play();        
    }
}

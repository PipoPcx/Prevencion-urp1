using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField] private AudioClip[] audios;

    private AudioSource controlAudio;

    private void Awake()
    {
        controlAudio = GetComponent<AudioSource>();
    }

    public void SeleccionAudio(int indice, float volume)
    {
        controlAudio.PlayOneShot(audios[indice], volume);
    }
}

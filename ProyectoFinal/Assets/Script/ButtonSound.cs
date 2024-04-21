using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSound : MonoBehaviour
{
    public AudioSource buttonSound; // Referencia al componente AudioSource que contiene el sonido del bot�n

    void Start()
    {
        // Buscar el componente AudioSource si no se ha asignado manualmente
        if (buttonSound == null)
        {
            buttonSound = GetComponent<AudioSource>();
        }
    }

    public void PlayButtonSound()
    {
        // Reproducir el sonido del bot�n cuando se presiona
        buttonSound.Play();
    }
}

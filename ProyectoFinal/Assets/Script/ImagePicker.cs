using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class ImagePicker : MonoBehaviour
{
    public Image imageToUpdate;

    // M�todo que se ejecutar� cuando se presione el bot�n
    public void PickImage()
    {
        // Abre la galer�a de im�genes del dispositivo
        NativeGallery.Permission permission = NativeGallery.GetImageFromGallery((path) =>
        {
            if (path != null)
            {
                // Carga la imagen seleccionada como sprite
                StartCoroutine(LoadImage(path));
            }
        }, "Seleccionar imagen", "image/*");

        Debug.Log("Permiso: " + permission);
    }

    // M�todo para cargar la imagen seleccionada como sprite
    private IEnumerator LoadImage(string path)
    {
        // Carga la imagen como una textura
        var loadTexture = NativeGallery.LoadImageAtPath(path);
        yield return loadTexture;

        // Verifica si la textura se carg� correctamente
        if (loadTexture != null)
        {
            // Crea un sprite con la textura cargada
            Sprite sprite = Sprite.Create(loadTexture, new Rect(0, 0, loadTexture.width, loadTexture.height), Vector2.one * 0.5f);

            // Actualiza la imagen con el nuevo sprite
            imageToUpdate.sprite = sprite;
        }
        else
        {
            Debug.LogError("Failed to load texture!");
        }
    }
}


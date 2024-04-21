using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    
    public static Manager instance;

    public string nombre_usuarioActual;
    public string correo_usuarioActual;
    public string contraseña_usuarioActual;

    public List<string> usuarios = new List<string>();

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        usuarios.Add(item: "Ivan");
    }



   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{
    public void Salir()
    {
        Application.Quit();
    }
    public void Otra(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }
}

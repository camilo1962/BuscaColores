using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOver : MonoBehaviour
{

    float tiempoFinal;
    public TMP_Text tiempoFinaltext;
    public TMP_Text recordText;
    private int minutos, segundos, centesimas;
    float tiempoRecord;

    private void Start()
    {
        
    }

    void Update()
    {
        tiempoFinal = GameManager.instance.tiempoFinal;
        minutos = (int)(tiempoFinal / 60f);
        segundos = (int)(tiempoFinal - minutos * 60f);
        centesimas = (int)((tiempoFinal - (int)tiempoFinal) * 100f);

        tiempoFinaltext.text = string.Format("{0:00}:{1:00}:{2:00}", minutos, segundos, centesimas);

        // Obtener el récord actual
        tiempoRecord = PlayerPrefs.GetFloat("record", Mathf.Infinity); // Establecer el tiempo récord inicialmente en "infinito"

        if (tiempoFinal < tiempoRecord) // Si el tiempo final es menor que el récord actual
        {
            PlayerPrefs.SetFloat("record", tiempoFinal); // Actualizar el récord en PlayerPrefs
            recordText.text = tiempoFinaltext.text; // Actualizar el texto del récord mostrado en pantalla
        }
        else
        {
            recordText.text = string.Format("{0:00}:{1:00}:{2:00}", (int)(tiempoRecord / 60f), (int)(tiempoRecord % 60), (int)((tiempoRecord - (int)tiempoRecord) * 100f)); // Mostrar el récord /actual
        }
    }

    public void BorraRecord()
    {
        PlayerPrefs.DeleteKey("record");
        recordText.text = "--:--:--"; // Actualizar el texto del récord a un valor por defecto
    }

    public void Salir()
    {
        Application.Quit();
    }
    public void Otra(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public float timer = 0f;
    public float tiempoFinal;
    public TMP_Text textoTimer;

    private int minutos, segundos, centesimas;

    public void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(this);
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        minutos = (int)(timer / 60f);
        segundos = (int)(timer - minutos * 60f);
        centesimas = (int)((timer - (int)timer) * 100f);

        textoTimer.text = string.Format("{0:00}:{1:00}:{2:00}", minutos, segundos, centesimas);
    }

    public void DetenerTiempo()
    {
        Time.timeScale = 0f;
        tiempoFinal = timer;
      
    }
}

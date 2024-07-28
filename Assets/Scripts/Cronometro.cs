using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cronometro : MonoBehaviour
{
    public TMP_Text cronometroText;
    // Start is called before the first frame update
    private float tiempoRestante = 60f;
    private bool cronometroActivo = false;
    public GameObject timeUpCanvas;
    public TMP_Text ScoreText;
    public TMP_Text ScoreTextFinal;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cronometroActivo)
        {
            tiempoRestante -= Time.deltaTime;
            cronometroText.text = "Time: " + Mathf.Round(tiempoRestante).ToString() + "s";

            if (tiempoRestante <= 0)
            {
                cronometroActivo = false;
                MostrarPuntajeTotal();
            }
        }
    }

    public void startCronometro()
    {
        cronometroActivo = true;
    }

    void MostrarPuntajeTotal()
    {
        timeUpCanvas.SetActive(true);
        ScoreTextFinal.text = ScoreText.text;
    }
}

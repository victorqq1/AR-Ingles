using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ControlAnimal : MonoBehaviour
{
    public List<GameObject> lista = new List<GameObject> ();
    public List<Boton> botones = new List<Boton>();
    public String opcorrecta;
    public Image correctFeedbackImage;
    public Image incorrectFeedbackImage;
    public int puntos = 0;
    public TMP_Text puntosText;
    void Start()
    {
        EscogerModelos();
    }

    public void EscogerModelos(){
        int rand = UnityEngine.Random.Range(0,lista.Count);
        for (int i = 0; i < lista.Count; i++)
        {
            lista[i].SetActive(false);
        }
        lista[rand].SetActive(true);
        opcorrecta = lista[rand].GetComponent<Modelo>().nombre;
        asignarBotones();
    }

    void asignarBotones(){
        List<string> nomanimales = new List<string>();
        for (int i = 0; i < lista.Count; i++)
        {
            nomanimales.Add(lista[i].GetComponent<Modelo>().nombre);
        }
        for (int i = 0; i < lista.Count; i++)
        {
            int rand = UnityEngine.Random.Range(0,nomanimales.Count);
            botones[i].nombre = nomanimales[rand];
            if (nomanimales[rand] == opcorrecta)
            {
                botones[i].esCorrecto = true;
            } else {
                botones[i].esCorrecto = false;
            }
            nomanimales.RemoveAt(rand);
        }
    }
    public IEnumerator MostrarImagenFeedback(Image feedbackImage)
    {
        feedbackImage.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        feedbackImage.gameObject.SetActive(false);
        EscogerModelos();
    }

    public void ActualizarPuntos()
    {
        puntos++;
        puntosText.text = "Points: " + puntos;
    }
}

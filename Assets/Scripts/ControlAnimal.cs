using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAnimal : MonoBehaviour
{
    public List<GameObject> lista = new List<GameObject> ();
    public List<Boton> botones = new List<Boton>();
    // Start is called before the first frame update
    public String opcorrecta;
    void Start()
    {
        EscogerModelos();
    }

    void EscogerModelos(){
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
    // Update is called once per frame
    void Update()
    {
        
    }
}

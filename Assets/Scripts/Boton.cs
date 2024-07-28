using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Boton : MonoBehaviour
{
    public string nombre;
    public bool esCorrecto;
    public TMP_Text texto;
    // Start is called before the first frame update
    void Start()
    {
        texto = this.GetComponentInChildren<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        texto.text = nombre;
    }

    public void clickBoton(){
        Debug.Log(esCorrecto);
    }
}

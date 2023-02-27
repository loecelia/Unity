using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Puntaje : MonoBehaviour
{
    private Transform transformPuntajeAlto;
    private Transform transformPuntajeActual;
    private TMP_Text textoPuntajeAlto;
    private TMP_Text textoActual;
    public PuntajeAlto puntajeAltoSO;
    //public int puntos = 0;
    //public int puntajeAlto = 1000;
   
    // Start is called before the first frame update
    void Start()
    {
        transformPuntajeActual = GameObject.Find("PuntajeActual").transform;
        transformPuntajeAlto = GameObject.Find("PuntajeAlto").transform;
        textoActual = transformPuntajeActual.GetComponent<TMP_Text>();
        textoPuntajeAlto = transformPuntajeAlto.GetComponent<TMP_Text>();
        //if (PlayerPrefs.HasKey("PuntajeAlto"))
        //{
        //puntajeAlto = PlayerPrefs.GetInt("PuntajeAlto");
        puntajeAltoSO.Cargar();
        textoPuntajeAlto.text = $"PuntajeAlto:{puntajeAltoSO.puntajeAlto}";
        puntajeAltoSO.puntaje = 0;
        //}
    }

    private void FixedUpdate()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textoActual.text = $"PuntajeActual: {puntajeAltoSO.puntaje}";
        if (puntajeAltoSO.puntaje > puntajeAltoSO.puntajeAlto)
        {
            puntajeAltoSO.puntajeAlto = puntajeAltoSO.puntaje;
            textoPuntajeAlto.text = $"PuntajeAlto:{puntajeAltoSO.puntajeAlto}";
            puntajeAltoSO.Guardar();
            //PlayerPrefs.SetInt("PuntajeAlto", puntos);
        }
    }

    public void AumentarPuntaje(int puntos)
    {
        puntajeAltoSO.puntaje  += puntos; 
    }
}

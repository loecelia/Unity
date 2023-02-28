using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using static Opciones;

public class Bloque : MonoBehaviour
{
    // Start is called before the first frame update

    public int resistencia;
    public UnityEvent AumentarPuntaje;
    public Opciones ObtenerDificultad;
   
    



    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bola")
        {
            RebotarBola(collision);
        }
    }

    public virtual void RebotarBola(Collision collision)
    {
        Vector3 direccion = collision.contacts[0].point - transform.position;
        direccion = direccion.normalized;
        collision.rigidbody.velocity = collision.gameObject.GetComponent<Bola>().velocidadBola * direccion;
        resistencia--;
    }

    void Start()
    {
        //asignar resistencia en funcio de dificultad
        if ((int)ObtenerDificultad.NivelDificultad == 0)
        {
            resistencia = 1;
        }
        if ((int)ObtenerDificultad.NivelDificultad == 1)
        {
            resistencia = 2;
        }
        if ((int)ObtenerDificultad.NivelDificultad == 2)
        {
            resistencia = 3;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (resistencia <= 0)
        {
            AumentarPuntaje.Invoke();
            Destroy(this.gameObject);
        }
    }

    public virtual void RebotarBola()
    {

    }
}

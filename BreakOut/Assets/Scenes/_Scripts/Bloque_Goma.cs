using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Goma : Bloque 
{
    
    // Start is called before the first frame update
    void Start()
    {
        if ((int)ObtenerDificultad.NivelDificultad == 0)
        {
            resistencia = 20;
        }
        if ((int)ObtenerDificultad.NivelDificultad == 1)
        {
            resistencia = 25;
        }
        if ((int)ObtenerDificultad.NivelDificultad == 2)
        {
            resistencia = 30;
        }
    }

    public override void RebotarBola()
    {
        base.RebotarBola();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Aluminio : Bloque 
{
    // Start is called before the first frame update
    void Start()
    {
        if ((int)ObtenerDificultad.NivelDificultad == 0)
        {
            resistencia = 8;
        }
        if ((int)ObtenerDificultad.NivelDificultad == 1)
        {
            resistencia = 9;
        }
        if ((int)ObtenerDificultad.NivelDificultad == 1)
        {
            resistencia = 10;
        }
    }

    public override void RebotarBola()
    {
        base.RebotarBola();
    }
}

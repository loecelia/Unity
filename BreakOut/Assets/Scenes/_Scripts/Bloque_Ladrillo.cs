using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Ladrillo : Bloque
{
    
    // Start is called before the first frame update
    void Start()
    {
        if ((int)ObtenerDificultad.NivelDificultad == 0)
        {
            resistencia = 2;
        }
        if ((int)ObtenerDificultad.NivelDificultad == 1)
        {
            resistencia = 4;
        }
        if ((int)ObtenerDificultad.NivelDificultad == 2)
        {
            resistencia = 6;
        }
    }

    public override void RebotarBola()
    {
        base.RebotarBola();
    }
}

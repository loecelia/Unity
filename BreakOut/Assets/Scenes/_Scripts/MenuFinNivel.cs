using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuFinNivel : MonoBehaviour
{
    //private int timeScale;
    public void SiguienteNivel()
    {
        var siguienteNivel = SceneManager.GetActiveScene().buildIndex + 1;
        if(SceneManager.sceneCountInBuildSettings > siguienteNivel)
        {
            SceneManager.LoadScene(siguienteNivel); 
        }
        else
        {
            CargarMenuPrincipal();
        }
    }
    public void CargarMenuPrincipal()
    {
        SceneManager.LoadScene(0);
    }
    public void ReintentarNivel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

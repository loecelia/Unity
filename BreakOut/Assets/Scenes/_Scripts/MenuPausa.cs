using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public GameObject menuPausa;
    public GameObject menuOpciones;
    private int timeScale;

    public void MostrarMenuPausa()
    {
        Time.timeScale = 0;
        menuPausa.SetActive(true);
        if (menuOpciones.activeInHierarchy) menuOpciones.SetActive(false);
    }

    public void OcultarMenuPausa()
    {
        
        menuPausa.SetActive(false);
        Time.timeScale = 1;
    }

    public void RegresarPantallaPrincipal()
    {
        SceneManager.LoadScene(0);
    }

    public void MostrarMenuOpciones()
    {
        menuPausa.SetActive(false);
        menuOpciones.SetActive(true);
    }
}

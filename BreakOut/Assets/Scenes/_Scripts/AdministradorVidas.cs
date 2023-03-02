using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdministradorVidas : MonoBehaviour
{
    private int timeScale;
    [HideInInspector] public List<GameObject> vidas;
    public GameObject bolaPrefab;
    private Bola bolaScript;
    public GameObject MenuFinJuego;

    // Start is called before the first frame update
    void Start()
    {
        Transform[] hijos = GetComponentsInChildren<Transform>();
        foreach (Transform hijo in hijos)
        {
            vidas.Add(hijo.gameObject);
        }
        
    }

    public void EliminarVida()
    {
        var ObjetoAEliminar = vidas[vidas.Count - 1];
        Destroy(ObjetoAEliminar);
        vidas.RemoveAt(vidas.Count - 1);
        if(vidas.Count <= 0)
        {
            MenuFinJuego.SetActive(true);
            Time.timeScale = 0;
            return;
        }
        var bola = Instantiate(bolaPrefab) as GameObject;
        bolaScript = bola.GetComponent<Bola>();
        bolaScript.BolaDestruida.AddListener(this.EliminarVida);
        Debug.Log($"Vidas restantes: {vidas.Count}");
    }
}

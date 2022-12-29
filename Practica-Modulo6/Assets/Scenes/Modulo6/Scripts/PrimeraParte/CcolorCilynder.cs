using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CcolorCilynder : MonoBehaviour
{
    public CColorCube ccolorcube;
    public CColorCube1 ccolorcube1;
    public GameObject cilindro;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if(ccolorcube.objeto3 && ccolorcube1.objeto4)
        {
            cilindro.GetComponent<MeshRenderer>().material.color = Color.white;
        }
        else
        {
            cilindro.GetComponent<MeshRenderer>().material.color = Color.black;
        }
    }
}

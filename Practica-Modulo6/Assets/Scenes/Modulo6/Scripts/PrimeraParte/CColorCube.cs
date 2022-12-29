using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CColorCube : MonoBehaviour
{
    
    public GameObject cuboOrig;
    public CColorSphere ccolorsphere;
    public CColorCapsule ccolorcapsule;
    public bool objeto3;
   

    private void Awake()
    {
        //Color c = new Color(Random.value, Random.value, Random.value);
        //cuboOrig.GetComponent<MeshRenderer>().material.color = c;
    }
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
        objeto3 = ccolorsphere.objeto1 && ccolorcapsule.objeto2;
        if (objeto3 == true)
        {
            cuboOrig.GetComponent<MeshRenderer>().material.color = Color.white;           
        }
        else
        {
            cuboOrig.GetComponent<MeshRenderer>().material.color = Color.black;
        }  
    }
}

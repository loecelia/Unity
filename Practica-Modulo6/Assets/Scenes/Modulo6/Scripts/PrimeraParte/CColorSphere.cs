using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CColorSphere : MonoBehaviour
{
    public GameObject sphere;
    public bool objeto1 = false;

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
        //Color c = new Color(Random.value, Random.value, Random.value);
        //sphere.GetComponent<MeshRenderer>().material.color = c;
        
        if (objeto1 == true)
        {
            sphere.GetComponent<MeshRenderer>().material.color = Color.white;
            objeto1 = false;
        }
        else
        {
            sphere.GetComponent<MeshRenderer>().material.color = Color.black;
            objeto1 = true;
        }
            

    }
}

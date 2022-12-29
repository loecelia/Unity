using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreaCubo3 : MonoBehaviour
{
    public GameObject cubo3;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   

    private void OnEnable()
    {
        Instantiate(cubo3);
        Color c = new Color(Random.value, Random.value, Random.value);
        cubo3.GetComponent<MeshRenderer>().material.color = c;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreaCubo2 : MonoBehaviour
{
    public GameObject cubo2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(cubo2);
        Color c = new Color(Random.value, Random.value, Random.value);
        cubo2.GetComponent<MeshRenderer>().material.color = c;
    }

    private void FixedUpdate()
    {
        Color c = new Color(Random.value, Random.value, Random.value);
        cubo2.GetComponent<MeshRenderer>().material.color = c;
    }

    
}

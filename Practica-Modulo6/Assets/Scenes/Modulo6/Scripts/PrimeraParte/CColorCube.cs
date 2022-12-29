using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CColorCube : MonoBehaviour
{
    public GameObject cuboOrig;

    private void Awake()
    {
        Color c = new Color(Random.value, Random.value, Random.value);
        cuboOrig.GetComponent<MeshRenderer>().material.color = c;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

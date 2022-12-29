using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CColorMatCubo : MonoBehaviour
{
   // public GameObject cubeO;
    public Material materialc;

    private void Awake()
    {
        Color c = new Color(Random.value, Random.value, Random.value);
        materialc.color = c;
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CColorMatEsfera : MonoBehaviour
{
    public Material materialesfera;

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
        Color c = new Color(Random.value, Random.value, Random.value);
        materialesfera.color = c;
    }
}

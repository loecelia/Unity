using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CColorMatCapsula : MonoBehaviour
{
    public Material materialcapsule;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Color c = new Color(Random.value, Random.value, Random.value);
        materialcapsule.color = c;
    }
}

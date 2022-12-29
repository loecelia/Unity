using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CColorCapsule : MonoBehaviour
{
    public GameObject capsule;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Color c = new Color(Random.value, Random.value, Random.value);
        capsule.GetComponent<MeshRenderer>().material.color = c;
    }
}

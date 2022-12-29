using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreaCubo1 : MonoBehaviour
{
    public GameObject cubo1;

    void Awake()
    {
        Instantiate(cubo1);
        Color c = new Color(Random.value, Random.value, Random.value);
        cubo1.GetComponent<MeshRenderer>().material.color = c;
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

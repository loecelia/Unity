using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CColorCapsule : MonoBehaviour
{
    public GameObject capsule;
    public bool objeto2 = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Color c = new Color(Random.value, Random.value, Random.value);
        //capsule.GetComponent<MeshRenderer>().material.color = c;

    }

    private void FixedUpdate()
    {
        if (objeto2 == true)
        {
            capsule.GetComponent<MeshRenderer>().material.color = Color.white;
            objeto2 = false;
        }
        else
        {
            capsule.GetComponent<MeshRenderer>().material.color = Color.black;
            objeto2 = true;
        }
    }
}

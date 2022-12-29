using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tarea7 : MonoBehaviour
{
    // Objetos
    public GameObject cube1;
    public GameObject cube2;
    public GameObject cube3;
    public GameObject cube4;
    public GameObject cube5;

    //variables booleanas
    bool cubo1, cubo2, cubo3, cubo4, cubo5;
   


    
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
        //GO 1
        cubo1 = !cubo1;
        //GO 2
        cubo2 = !cubo2;
        //GO 3
        cubo3 = (cubo1 && cubo2);
        //GO 4
        cubo4 = (cubo1 || cubo2);
        //GO 5
        cubo5 = (cubo3 && cubo4);

        

        if (cubo1)
        {
            var meshRenderMaterial = cube1.GetComponent<MeshRenderer>().material;
            meshRenderMaterial.color = Color.white;
            cube1.transform.position = Vector3.one;
        } 
        else 
        {
            var meshRenderMaterial = cube1.GetComponent<MeshRenderer>().material;
            meshRenderMaterial.color = Color.black;
            cube1.transform.position = Vector3.one;
        }

        if (cubo2)
        {
            var meshRenderMaterial = cube2.GetComponent<MeshRenderer>().material;
            meshRenderMaterial.color = Color.white;
            cube2.transform.position = Vector3.one;
        }
        else
        {
            var meshRenderMaterial = cube2.GetComponent<MeshRenderer>().material;
            meshRenderMaterial.color = Color.black;
            cube2.transform.position = Vector3.one;
        }

        if (cubo3)
        {
            var meshRenderMaterial = cube3.GetComponent<MeshRenderer>().material;
            meshRenderMaterial.color = Color.white;
            cube3.transform.position = Vector3.one;
        }
        else
        {
            var meshRenderMaterial = cube3.GetComponent<MeshRenderer>().material;
            meshRenderMaterial.color = Color.black;
            cube3.transform.position = Vector3.one;
        }

        if (cubo4)
        {
            var meshRenderMaterial = cube4.GetComponent<MeshRenderer>().material;
            meshRenderMaterial.color = Color.white;
            cube4.transform.position = Vector3.one;
        }
        else
        {
            var meshRenderMaterial = cube4.GetComponent<MeshRenderer>().material;
            meshRenderMaterial.color = Color.black;
            cube4.transform.position = Vector3.one;
        }
        if (cubo5)
        {
            var meshRenderMaterial = cube5.GetComponent<MeshRenderer>().material;
            meshRenderMaterial.color = Color.white;
            cube5.transform.position = Vector3.one;
        }
        else
        {
            var meshRenderMaterial = cube5.GetComponent<MeshRenderer>().material;
            meshRenderMaterial.color = Color.black;
            cube5.transform.position = Vector3.one;
        }
    }
}

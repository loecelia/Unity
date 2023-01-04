using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    
    public GameObject cuboOrig;
    //1.1) Crear dos variables: una entera y una float
    int i1 = 15;
    float f1 = 1.5f;
    //1.2) Crear dos variables flotantes
    float f2 = 80.4f;
    float f3 = 500.33456095f;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("El valor del entero es " + i1);
        Debug.Log("El valor del float es " + f1);
        //1.2.2) Operacion entre flotantes
        int res = (int)(f2 + f3);
        Debug.Log("El resultado de los dos flotantes como entero es " + res);
        //1.4) string y sentencia switch
        string mipalabra = "Murcielago";
        int longpalabra = mipalabra.Length;
        for (int i=0; i < longpalabra; i++) 
        {
            cuboOrig.GetComponent<MeshRenderer>().material.color = mipalabra[i] switch
            {
                'a' => Color.cyan,
                'e' => Color.green,
                'i' => Color.blue,
                'o' => Color.red,
                'u' => Color.yellow,
                _ => Color.black,
            };
        }

        //1.5) Convertir flotante a string
        string f3Str = f3.ToString("00.0000");
        Debug.Log("El valor de f3 como texto es " + f3Str);
        
        //1.6.1) Metodo substring
        string miNombreCom = "Loecelia Ruvalcaba Sanchez";
        string nombre = miNombreCom.Substring(0,8);
        string ApellidoP = miNombreCom.Substring(9, length: 9);
        string ApellidoM = miNombreCom.Substring(19, length:7); 
        Debug.Log("Mi nombre es " + nombre);
        Debug.Log("Mi apellido paterno es " + ApellidoP);
        Debug.Log("Mi apellido materno es " + ApellidoM);

        //1.6.2) Metodo Split
        string[] sMiNombre = miNombreCom.Split(' ');
        foreach (var sub in sMiNombre)
        {
            Debug.Log($"Substrings: {sub}");
        }

        //2.1) Dos variables string con valores numericos
        string snum1 = "1278";
        string snum2 = "5789";
        //int num1, num2; 
        int.TryParse(snum1, out int num1);
        int.TryParse(snum2, out int num2);
        int num3 = num1 + num2;
        Debug.Log($"La suma de {num1} + {num2} es = {num3}");

        //2.2 impresion caracteres impares
        string miSaludo = "Hola Mundo";
        for (int i= 0; i<miSaludo.Length; i++)  
        {
            if ((int)i % 2==0) 
            {
                Debug.Log(miSaludo[i]);
            }
                
        }

        //2.3) Eliminar cinco primeros caracteres de string
        string miFrase = "Cada quien su rollo ";
        miFrase = miFrase.Substring(5, length:14);
        Debug.Log("Mi frase es: " + miFrase);


    }

    private void FixedUpdate()
    {
        f1 *= 3;
        //1.3) Par o impar?
        if ((int)f1 % 2 == 0)
        {
            //Debug.Log("El numero " + f1 + "es par");
            cuboOrig.GetComponent<MeshRenderer>().material.color = Color.white;
        }
        else
        {
            //Debug.Log("El numero " + f1 + "es impar");
            cuboOrig.GetComponent<MeshRenderer>().material.color = Color.black;
        }


    }

    // Update is called once per frame
    void Update()
    {
        i1++;
        //Debug.Log(i1);

    }
}

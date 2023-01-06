using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosdeCiclosyArreglos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //1) Se crean dos arreglos unidimensionales; se llenan con valores aleatorios y se suman en un tercero
        int[] miArreglo1 = new int[5];
        int[] miArreglo2 = new int[5];
        int[] miArreglo3 = new int[5];
       
        for (int i = 0; i < 5; i++)
        {
            miArreglo1[i] = Random.Range(1,100);
            miArreglo2[i] = Random.Range(5, 90);
            miArreglo3[i] = miArreglo1[i] + miArreglo2[i];
        }
        for (int i = 0; i < miArreglo1.Length; i++)
        {
            Debug.Log($"La suma de {miArreglo1[i]} + {miArreglo2[i]} = {miArreglo3[i]}");
        }

        //2) Arreglo de string de una palabra y concatenar en string para imprimir
        string[] misPalabras = new string[5] {"Haz", "que", "cada", "día","cuente"};
        string miFrase="";
        foreach(string s in misPalabras)
        {
            miFrase += s + " ";
        }
        Debug.Log(miFrase);

        //3) arreglo multidimensional y multiplicacion matriz arreglo
        //Declaracion matriz
        int[,] miMatriz = new int[2, 3];
        //Llenado matriz con aleatorios
        for (int i = 0; i < miMatriz.GetLength(0); i++)
        {
            for (int j = 0; j < miMatriz.GetLength(1); j++)
            {
                miMatriz[i, j] = Random.Range(1, 30);
            }
        }
        //Declaracion y llenado arreglo
        int[] miVector = new int[3];
        for (int i=0; i< miVector.Length; i++)
        {
            miVector[i] = Random.Range(1, 15);
        }
        //Multiplicación matriz
        int[] miResultado = new int[2];
        for (int i = 0; i < miMatriz.GetLength(0); i++)
        {
            for (int j = 0; j < miMatriz.GetLength(1); j++)
            {
                miResultado[i] += miMatriz[i, j] * miVector[j];
            }
        }
        for (int i=0; i<miResultado.Length; i++)
        {
            Debug.Log($"El resultado {i} es {miResultado[i]}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

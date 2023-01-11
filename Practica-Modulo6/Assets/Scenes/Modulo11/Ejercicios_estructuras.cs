using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ejercicios_estructuras : MonoBehaviour
{
    List<int> listaNumeros = new List<int>();
    List<string> listaStrings = new List<string>();
    HashSet<string> hashSetStrs = new HashSet<string>();
    Stack<string> pilaStrings = new Stack<string>();
    Queue<string> colaStrings = new Queue<string>();
    
    int[] arregloOriginal = new int[10];
    int[] arregloOrdenado = new int[10];    

    // Start is called before the first frame update
    void Start()
    {
        //Llamada funciones inciso 1
        listaNumeros = miFuncion1(10, 0, 50);
        imprimeLista(listaNumeros);

        //Llamada funciones inciso 2
        Debug.Log("Inicia Impresión Arreglo");
        for(int i=0; i<10; i++)
        {
            arregloOriginal[i] = Random.Range(1, 80);
        }
        arregloOrdenado = ordenaArreglo(arregloOriginal);
        imprimeArreglo(arregloOrdenado);

        //Llamada funciones inciso 3
        listaStrings.Add("Aguascalientes");
        listaStrings.Add("Jalisco");
        listaStrings.Add("Aguascalientes");
        listaStrings.Add("Zacatecas");
        listaStrings.Add("Jalisco");
        hashSetStrs = eliminaRepetidos(listaStrings);
        imprimeHashSet(hashSetStrs);

        //Llamada funciones inciso 4
        pilaStrings.Push("Uno");
        pilaStrings.Push("Dos");
        pilaStrings.Push("Tres");
        pilaStrings.Push("Cuatro");
        pilaStrings.Push("Cinco");
        miFuncion4(pilaStrings);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //1) Funcion que recibe tres parametros, llena lista con numeros aleatorios
    public List<int> miFuncion1(int tamano, int rangoInferior, int rangoSuperior)
    {
        List<int>  miLista = new List<int>();
        //Llenar lista
        for (int i = 0; i < tamano; i++)
        {
            miLista.Add(Random.Range(rangoInferior, rangoSuperior));
        }
        return miLista;
    }

    public void imprimeLista (List<int> miLista)
    {
        foreach (var numero in miLista)
        {
            Debug.Log(numero);
        }
    }

    //2)Funcion recibe arreglo de enteros y regresa enteros ordenados
    public int[] ordenaArreglo(int[] arreglodes)
    {
        int[] arregloInt = new int [10];
        int temp;
        arregloInt = arreglodes;        
        for(int i=0; i<9; i++)
        {
            for(int j=i+1; j<10; j++)
            {
                if (arregloInt[i] < arregloInt[j])
                {
                    temp = arregloInt[i];
                    arregloInt[i] = arregloInt[j];
                    arregloInt[j] = temp;
                }
            }
        }
        return arregloInt;
    }

    public void imprimeArreglo(int[] arregloImp)
    {
        for(int i=0; i<10; i++)
        {
            Debug.Log(arregloImp[i]);
        }
    }

    //3) Funcion recibe lista y regresa hashsets sin elementos
    public HashSet<string> eliminaRepetidos(List<string> miLista)
    {
        HashSet<string> hashSetTmp = new HashSet<string>();
        foreach(var cadena in miLista)
        {
            hashSetTmp.Add(cadena);
        }
        return hashSetTmp;
    }

    public void imprimeHashSet(HashSet<string> miHashSet)
    {
        foreach(var cadena in miHashSet)
        {
            Debug.Log(cadena);
        }
    }

    //4) Función recibe pila, la imprime y llena cola
    public void miFuncion4(Stack<string> miPila)
    {
        Debug.Log("Imprime Pila");
        for (int i=0; i<5; i++)
        {
            string cadena = miPila.Peek();
            Debug.Log(cadena);
            miPila.Pop();
            colaStrings.Enqueue(cadena);
        }
        Debug.Log("Imprime Cola");
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(colaStrings.Peek());
            colaStrings.Dequeue();
        }

    }

}

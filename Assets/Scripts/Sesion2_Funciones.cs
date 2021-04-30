using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sesion2_Funciones : MonoBehaviour
{
    int age = 32;
    // Start is called before the first frame update
    void Start()
    {
        ShowHelloMessage();

        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
            {
                break;
            }
            Debug.Log(i);
        }


        Debug.Log("get Age is " + GetAge());

        Debug.Log("Suma es en int " + Suma(2, 8));
        Debug.Log("Suma es en int " + Suma(Vector3.right,Vector3.up)    );
        Debug.Log("Suma es en int " + Suma("mi gatito", "DICE MIUAU"));
        Debug.Log("Suma es en int " + Suma(0.12f, Time.deltaTime));

 

    }
    
    public void ShowHelloMessage()
    {
        Debug.Log("Hi this is hello function");
    }
   
    public int GetAge()
    {
        return age;
    }

    public bool  GetPercent()
    {
        float percent= 100f / 20f;

        if (percent < .2f)
        {
            return true;
        }

       return false;
    }
    /// <summary>
    /// Overload ->sobrecargas
    /// </summary>
    /// <param name="A"></param>
    /// <param name="B"></param>
    /// <returns></returns>
    private int Suma(int A,int B)
    {
        int total = A + B;

        return total;

    }

    private float Suma(float A, float B)
    {
        float total = A + B;

        return total;
    }
    private Vector3 Suma(Vector3 A, Vector3 B)
    {
        Vector3 total = A + B;

        return total;
    }
    private string Suma(string A, string B)
    {
        string total = A + B;

        return total;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//global
public enum EFruta { Manzana,Platano,Naranja,Uva }

//Ambito de la variable
public class Sesion1 : MonoBehaviour
{
    //Variables Generales o  Globales de clase
    public int entero;
    private float flotantes;
    public string nombre = "Player Name";
    public Vector3 posicion;
    protected Vector2 screenPosition;//camelCase
    byte streamingData;
    public float[] grados;

    public EFruta fruta;

    // Start is called before the first frame update
    void Start()
    {
        //Variables locales
        float damage = 25;

        Debug.Log(nombre);
        Debug.Log(damage);

        if(fruta==EFruta.Naranja)
        {
            Debug.Log(" if => tengo naranjas");
        }else if(fruta==EFruta.Manzana)
        {
            Debug.Log(" if => Tengo Manzana");
        }else if(fruta== EFruta.Uva)
        {
            Debug.Log(" if => Tengo Uva");
        }

        switch (fruta)
        {
            case EFruta.Manzana:
                Debug.Log(" switch => Tengo Manzana");
                break;

            case EFruta.Naranja:
                Debug.Log(" switch => tengo naranjas");

                break;
           /* default:
            
                Debug.Log(" switch => tutti fruti");
                break;*/
        }


    }

    // Update is called once per frame
    void Update()
    {
        /* float damage = 30;
       Debug.Log(entero);
        Debug.Log(damage);*/
    }
}

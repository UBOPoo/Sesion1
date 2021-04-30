using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Car
{
    public float speed;
    public string model;
    public int tires;
    public string engine;
    private float gas;
    public bool isOn;

    public Car()
    {
        gas = 100;
        tires = 4;
    }

    public Car(float Newgas)
    {

        gas = Newgas;
        tires = 4;
    }


    public void TurnEngineOn(bool turnOn)
    {
        isOn = turnOn;

    }
    public virtual void MoveForward()
    {
        if (gas <= 0) return;

        //gas=gas-Time.deltaTime;
        gas -= Time.deltaTime;

        Debug.Log("Moving forward, Gas is " + gas);
    }


    public void Brake()
    {
        Debug.Log("Braking" );
    }

    public void Back()
    {
        Debug.Log("Moving back");
    }
    public void Turn(bool isTurningLeft)
    {
        Debug.Log("Turning");
    }
}

[System.Serializable]
public class ElectricCar:Car
{
    public float power;
    public bool autoDrive;
    public ElectricCar()
    {
        power = 100;

    }
    public ElectricCar(float NewPower,bool NewAutoDrive)
    {
        power = NewPower;
        autoDrive = NewAutoDrive;
    }
    public override void MoveForward()
    {
        if (power <= 0) return;

        //gas=gas-Time.deltaTime;
        power -= Time.deltaTime;

        Debug.Log("Electric Moving forward, Power is " + power);
    }

}

public class PlasmaCar :ElectricCar
{

    public override void MoveForward()
    {
        Debug.Log("And is Flying!");
        base.MoveForward();

       
    }
}

public class Sesion3_Clases : MonoBehaviour
{
    public Car audi;
    public Car suv;
    public ElectricCar tesla;
    public PlasmaCar pepitosCar;
    
    // Start is called before the first frame update
    void Start()
    {

        audi = new Car();
        suv = new Car(200);
        tesla = new ElectricCar(120, false);

        pepitosCar = new PlasmaCar();



    }

    // Update is called once per frame
    void Update()
    {
       // audi.MoveForward();
        ///suv.MoveForward();
        //tesla.MoveForward();
        pepitosCar.MoveForward();

    }
}

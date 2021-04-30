using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sesion4_SendMessage : MonoBehaviour
{
    public GameObject other;

    public GameObject otherChild;

    public GameObject otherWithNoScript;

    // Start is called before the first frame update
    void Start()
    {
        other.SendMessage("SayHello");

         otherChild.BroadcastMessage("SayHello");

     
      otherWithNoScript.SendMessage("SayHello",SendMessageOptions.DontRequireReceiver);

    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sesion2_While : MonoBehaviour
{
    float counter;
    // Start is called before the first frame update
    void Start()
    {
         int i=0;
        while(counter<1002)//threads
        {
            Debug.Log("While "+ counter);
            counter += Time.deltaTime;// counter=counter+Time.deltaTime
                                      // counter++;//counter=counter+1;
            i++;

            if (i > 1000)
            {
                Debug.LogError("muchos loops!");
                break;
            }
        }

        do
        {
            Debug.Log("do While " + counter);
            counter += Time.deltaTime;// counter=counter+Time.deltaTime

        } while (counter < 0);


    }


    
}

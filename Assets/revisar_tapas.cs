using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class revisar_tapas : MonoBehaviour
{
    // Start is called before the first frame update
    public static int contar=-1;
    public static int seguir=1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (contar!=(rotate.contar/2) && rotate.contar%2==0 && piston.pasar==0)
        {
            seguir=0;
        }
        //print("tapa "+contar);
        print("contar: "+piston.pasar);
    }
    void OnTriggerEnter(Collider col){
        
        if (col.gameObject.name=="tapa-1" || col.gameObject.name=="tapa-2" || col.gameObject.name=="tapa-3" || col.gameObject.name=="tapa-4" || col.gameObject.name=="tapa-5" || col.gameObject.name=="tapa-6")
        {
            contar++;
            
            
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambiar_color : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (revisar_tapas.seguir==0)
        {
            GameObject.Find("Cube").GetComponent<Renderer>().material.SetColor("_Color",Color.yellow);
        }
        
    }
}

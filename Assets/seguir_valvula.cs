using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seguir_valvula : MonoBehaviour
{
    // Start is called before the first frame update
    public static Rigidbody valvula;
    public static Vector3 objeto;
    void Start()
    {
        
        valvula=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        objeto=transform.position;
    }
}

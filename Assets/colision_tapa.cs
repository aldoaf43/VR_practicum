using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colision_tapa : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    private Vector3 pos_inicial;
    public static int mover_tapa;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        mover_tapa=0;
    }

    // Update is called once per frame
    void Update()
    {
        float speed=100f;
        pos_inicial=rb.transform.position;
        Vector3 pos_valvula= new Vector3(seguir_valvula.objeto.x-0.575f,seguir_valvula.objeto.y-0.3873f,seguir_valvula.objeto.z-0.49f);
        if (mover_tapa==1)
        {
            rb.transform.position=Vector3.Lerp(pos_inicial,pos_valvula,speed*Time.deltaTime);
        }
        
        
    }
    void OnCollisionEnter(Collision col){
        
        if (col.gameObject.name=="base")
        {
            mover_tapa=1;
        }
    }
}

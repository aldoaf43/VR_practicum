using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover_tapa_1 : MonoBehaviour
{
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
        Vector3 pos_valvula= new Vector3(seguir_valvula.objeto.x-0.575f,seguir_valvula.objeto.y-0.4373f,seguir_valvula.objeto.z-0.49f);
        if(mover_tapa==1 && rotate.contar%2==0){
            rb.constraints=RigidbodyConstraints.FreezeRotation;
            rb.constraints=RigidbodyConstraints.FreezePositionX;
            rb.constraints=RigidbodyConstraints.FreezePositionZ;
        }else if (mover_tapa==1 && rotate.contar<12){
            rb.transform.position=Vector3.Lerp(pos_inicial,pos_valvula,speed*Time.deltaTime);
            rb.constraints=RigidbodyConstraints.FreezeAll;
        }
        
        
    }
    void OnCollisionEnter(Collision col){
        
        if (col.gameObject.name=="base")
        {
            mover_tapa=1;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class rotate : MonoBehaviour
{
    
     // Start is called before the first frame update
    private Rigidbody rb;
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private float _speed;
    public static int regresar;
    public static int contar;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        regresar=0;
        contar=0;
    }
    
    private Vector3 final= new Vector3(0,0,124f);
    private Vector3 final_1= new Vector3(0,0,123f);
    private Vector3 inicial= new Vector3(0,0,-14f);
    private Vector3 inicial_1= new Vector3(0,0,-13f);
    
    void Update (){
        float step=_speed*Time.deltaTime;
        
       
       if(rb.transform.rotation.z>0.87 && regresar==0){
            regresar=1;
            contar++;
        }
        if (piston.pasar==0)
        {
            if (rb.transform.rotation.z<=0.87 && regresar==0){
                rb.transform.rotation = Quaternion.Slerp(rb.transform.rotation, Quaternion.Euler(final),step);
            
            }
        }
        if (rb.transform.rotation.z<=0.87 && regresar==0 && contar%2==1){
                rb.transform.rotation = Quaternion.Slerp(rb.transform.rotation, Quaternion.Euler(final),step);
            
            }
        
        print("contar: "+contar);
        
        if(rb.transform.rotation.z<-0.11 && regresar==1){
            regresar=0;
            
        }
        if (piston.pasar==1)
        {
           if(rb.transform.rotation.z>=-0.11 && regresar==1){
                rb.transform.rotation = Quaternion.Slerp(rb.transform.rotation, Quaternion.Euler(inicial),step);
            } 
        }

        
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piston : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    [SerializeField] private Vector3 _position;
    [SerializeField] private float _speed;
    public static int pasar;
    private int empezar;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        pasar=0;
        empezar=0;
        StartCoroutine(ExampleCoroutine());
        /*final=new Vector3(rb.transform.position.x,rb.transform.position.y,rb.transform.position.z-0.1626f);
        final_1=new Vector3(final.x,final.y,final.z-0.1f);
        inicial=rb.transform.position;
        inicial_1=new Vector3(inicial.x,inicial.y,inicial.z+0.1f);
        print (""+final);*/
        
    }
    // Update is called once per frame

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(1);
        empezar=1;
    }
    private Vector3 final= new Vector3(0.2123f,1.523f,-0.094f);
    private Vector3 final_1= new Vector3(0.2123f,1.523f,-0.1f);
    private Vector3 inicial= new Vector3(0.2123f,1.523f,-0.2566f);
    private Vector3 inicial_1= new Vector3(0.2123f,1.523f,-0.25f);
    
    
    void Update (){
        
        float step =  _speed * Time.deltaTime;
        
        if (empezar==1){
            if(rb.transform.position.z>final_1.z && pasar==0){
                pasar=1;
                
            }
            if (rotate.regresar==1)
            {
                if (rb.transform.position.z<=final_1.z && pasar==0){
                    rb.transform.position=Vector3.Lerp(rb.position,final,step);   
                }
            }
            
            //print("pasar: "+pasar);
            if(rb.transform.position.z<inicial_1.z && pasar==1){
                pasar=0;
                
            }
            if (rotate.regresar==0)
            {
               if(rb.transform.position.z>=inicial.z && pasar==1){
                    rb.transform.position=Vector3.Lerp(rb.position,inicial,step);
                } 
            }
            
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piston : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    [SerializeField] private Vector3 _position;
    [SerializeField] private float _speed;
    private int pasar;
    private int empezar;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        pasar=0;
        empezar=0;
        StartCoroutine(ExampleCoroutine());
    }
    // Update is called once per frame

    IEnumerator ExampleCoroutine()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(1);
        empezar=1;

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }
    private Vector3 final= new Vector3(0.1064f,0.8109f,-0.045f);
    private Vector3 final_1= new Vector3(0.1064f,0.8109f,-0.046f);
    private Vector3 inicial= new Vector3(0.1064f,0.8109f,-0.128f);
    private Vector3 inicial_1= new Vector3(0.1064f,0.8109f,-0.127f);
    
    
    void Update (){
        
        float step =  _speed * Time.deltaTime;
        if (empezar==1)
        {
            
        
        if(rb.transform.position.z>final_1.z && pasar==0){
            pasar=1;
            
        }
        if (rb.transform.position.z<=final_1.z && pasar==0){
            rb.transform.position=Vector3.Lerp(rb.position,final,step);
            
        }
        
        
        if(rb.transform.position.z<inicial_1.z && pasar==1){
            pasar=0;
            
        }
        if(rb.transform.position.z>=inicial.z && pasar==1){
            rb.transform.position=Vector3.Lerp(rb.position,inicial,step);
        }
        
        }
    }
}

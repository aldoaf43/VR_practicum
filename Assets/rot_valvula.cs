using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rot_valvula : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb_valvula;
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private float _speed;
    void Start()
    {
        rb_valvula = GetComponent<Rigidbody>();
    }
    private Vector3 final_1= new Vector3(0,0,0f);
    // Update is called once per frame
    void Update (){
        
        rb_valvula.transform.rotation=Quaternion.Slerp(rb_valvula.transform.rotation,Quaternion.Euler(final_1),_speed*Time.deltaTime);
        
        
    }
}

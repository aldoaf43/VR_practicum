using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brazo_movimiento : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private float _speed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    int a = 0;
    // Update is called once per frame
    void Update()
    {
        /*
        while(a<1)
        {
            transform.position += transform.forward;
            a++;
        }
        */
        transform.Rotate (_rotation* _speed * Time.deltaTime);
        
    }
}

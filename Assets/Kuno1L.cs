using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using System.Diagnostics;
using System.Linq.Expressions;



public class Kuno1L: MonoBehaviour
{
    public float speed;
    public float horizontalInput;
    public float position;
    private Rigidbody2D rb;



    // Start is called before the first frame update
    void Start()
    {
        speed = 4;
    }


    // Update is called once per frame
    void Update()
    {
        
            rb = GetComponent<Rigidbody2D>();
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
        

    }
}




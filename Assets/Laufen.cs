using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using System.Diagnostics;

public class Laufen : MonoBehaviour
{
    public float speed;
    public float horizontalInput;
    public float position;
    public float cooldownTime = 20;
    private float nextDashTime = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        speed = 4;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
        if (Time.time > nextDashTime)
        {
            if (Input.GetKeyDown("space") && Input.GetKey("right"))
            {

                transform.position = transform.position + new Vector3(8, 0, 0);
                nextDashTime = Time.time + cooldownTime*2;
            }
            else if (Input.GetKeyDown("space") && Input.GetKey("left"))
            {
                transform.position = transform.position + new Vector3(-8, 0, 0);
                nextDashTime = Time.time + cooldownTime*2;
            }
        }
    }
}



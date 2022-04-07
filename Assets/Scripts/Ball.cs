using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Ball ball_spawn;
    public float speed = 3;
    Rigidbody rb; 
    Animator anim;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Launch();
        InvokeRepeating("Launch", 1.5f, 1.5f);
    }

    void Launch()
    {
        float x = Random.Range(-6f, 6f);
        float z = Random.Range(-6f, 6f);
        
        if (x == 0)
        {
            x = 1;
        }
        if (z == 0)
        {
            z = -1;
        }
        Vector3 target= new Vector3(x * speed, 0, z * speed);
        rb.velocity = new Vector3(x * speed, 0, z * speed);




        Vector3 dir = target - transform.position;
        Quaternion rotation = Quaternion.LookRotation(-dir , Vector3.up);
        transform.rotation = rotation;
        transform.Translate(dir * speed * Time.deltaTime, Space.World);
    }


}

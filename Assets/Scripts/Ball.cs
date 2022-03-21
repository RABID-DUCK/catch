using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Ball ball_spawn;
    public float speed = 10;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Launch();
        InvokeRepeating("Launch", 1.5f, 1.5f);
    }
  //  private void Update()
   // {
       // newfunct();
  //  }
    void Launch()
    {
        float x = Random.Range(-2, 2);
        float z = Random.Range(-2, 2);
        if (x == 0)
        {
            x = 1;
        }
        if (z == 0)
        {
            z = -1;
        }
        rb.velocity = new Vector3(x * speed, 0, z * speed);
        
    }
    public void newfunct()
    {
      /*  if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            Debug.Log(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == gameObject)
                {
                    Destroy(hit.collider.gameObject);
                }
            }
        }*/
    }
}

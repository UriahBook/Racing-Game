using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnSystem : MonoBehaviour
{

    GameObject body, wheelB, wheelF;
    Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        body = GameObject.Find("Body");
        wheelB = GameObject.Find("Wheel_B");
        wheelF = GameObject.Find("Wheel_F");
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag == "Track")
        {
            body.transform.position = startPos;
            body.transform.rotation = Quaternion.identity;
            body.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            body.GetComponent<Rigidbody2D>().angularVelocity = 0;

            wheelB.GetComponent<Rigidbody2D>().angularVelocity = 0;
            wheelF.GetComponent<Rigidbody2D>().angularVelocity = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.tag == "Checkpoint")
        {
            startPos = c.transform.position;
        }
    }

}

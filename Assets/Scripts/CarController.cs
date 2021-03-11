using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public Rigidbody2D body, wheel_f, wheel_b;
    public float power, bodyPower;

    void Start()
    {
        body = GameObject.Find("Body").GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (Input.GetKey("d"))
        {
            wheel_b.AddTorque(-power);
            wheel_f.AddTorque(-power);
            body.AddTorque(-bodyPower);
        }

        if (Input.GetKey("a"))
        {
            wheel_f.AddTorque(power);
            wheel_b.AddTorque(power);
            body.AddTorque(bodyPower);
        }
    }
}

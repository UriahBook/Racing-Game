using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public Rigidbody2D body, wheel_f, wheel_b;
    public float power, bodyPower;

    // Start is called before the first frame update
    void Start()
    {
        body = GameObject.Find("Body").GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
        {
            wheel_f.AddTorque(-power);
            wheel_b.AddTorque(-power);
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

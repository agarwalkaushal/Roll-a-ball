using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody rigidB;
    float speed = 350;

    void Start()
    {
        Application.targetFrameRate = 60;
        rigidB = gameObject.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 tilt = Input.acceleration;
        tilt = Quaternion.Euler(90, 0, 0) * tilt;
        rigidB.AddForce(tilt * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidB.AddForce(Vector3.forward * speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rigidB.AddForce(Vector3.back * speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidB.AddForce(Vector3.right * speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidB.AddForce(Vector3.left * speed);
        }
    }
}

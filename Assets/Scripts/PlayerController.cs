using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.5f;

    private float horizontalInput;
    private float forwardInput;

    private float xRange = 25.0f;
    private float zRange = 5.0f;

    public float RotateSpeed = 3.0F;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.up * horizontalInput * turnSpeed * Time.deltaTime);

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * turnSpeed);

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3( -xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xRange)
        {
            transform.position = new Vector3( xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }
        else if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}


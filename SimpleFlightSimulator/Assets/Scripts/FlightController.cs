using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
* A basic flight controller for a plane
* Created by Brandon Aldridge on 8/28/2020
*/

public class FlightController : MonoBehaviour
{
    public float speed = 10;
    // public float speedLimit = 10;

    //current flight direction
    // public Vector3 flightVector;

    //vector forces on local axes
    // public float thrust;            //-x    
    // public float liftCoefficient;   //y

    //rotation around local axes
    public float pitch = 40; //x
    public float roll = 40;  //z
    public float yaw = 40;   //y

    // Rigidbody m_Rigidbody;
    // float m_Speed;

    void Start()
    {
        // //Fetch the Rigidbody component you attach from your GameObject
        // m_Rigidbody = GetComponent<Rigidbody>();
        // //Set the speed of the GameObject
        // m_Speed = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        float pitchInput = Input.GetAxis("Vertical");
        float yawInput = Input.GetAxis("Horizontal");
        float rollInput = Input.GetAxis("Roll");

        transform.Rotate(new Vector3(pitch * pitchInput, yaw * yawInput,roll * rollInput) * Time.deltaTime);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        
        // transform.Translate(Vector3.ClampMagnitude(transform.forward * speed, speedLimit) * Time.deltaTime);
    }

    void OnDrawGizmos()
    {

        // Draws a blue line from this transform forward
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.forward * 2);
    }
}

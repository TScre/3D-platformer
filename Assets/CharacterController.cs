﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float maxSpeed = 3.0f;
    float rotation = 0.0f;
    public float camRotaion = 1.0f;
    GameObject cam;
    float rotaionSpeed = 2.0f;
    public float camRotaionSpeed = 1.5f;
    Rigidbody myRidgidbody;
   
    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("Main Camera");
        myRidgidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        isOnGround = Physics. CheckSphere(groundChecker.transform.position, 0.1f, ground );

        Vector3 newVelocity = transform.forward * Input.GetAxis("Vertical") * maxSpeed + (transform.right * Input.GetAxis("Horizontal") * maxSpeed);
        myRidgidbody.velocity = new Vector3(newVelocity.x, myRidgidbody.velocity.y, newVelocity.z);

        rotation = rotation + Input.GetAxis("Mouse X") * rotaionSpeed;
        transform.rotation = Quaternion.Euler(new Vector3(0.0f, rotation, 0.0f));

        camRotaion = camRotaion + Input.GetAxis("Mouse Y") * camRotaionSpeed;
        cam.transform.localRotation = Quaternion.Euler(new Vector3(-camRotaion, 0.0f, 0.0f));

    }
}
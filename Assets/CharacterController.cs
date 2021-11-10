﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    public float maxSpeed = 1.0f;
    float rotation = 0.0f;
    float camRotation = 0.0f;
    GameObject cam;

    // Start is called before the first frame update
    void Start()
    {
      cam = GameObject.Find("Main Camera"); 
    }

    // Update is called once per frame

    void Update()
    {
        
    transform.position = transform.position + (transform.forward * Input.GetAxis("Vertical") * maxSpeed);

    rotation = rotation + Input.GetAxis("Mouse X");
    transform.rotation = Quaternion.Euler(new Vector3(0.0f, rotation, 0.0f));

    camRotation = camRotation + Input.GetAxis("Mouse Y");
    }
}
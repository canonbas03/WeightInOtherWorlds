using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateImage : MonoBehaviour
{
    //public float rotationSpeed = 1f; // Speed of rotation
    public float maxRotation = 30f;   // Maximum degrees to rotate

    
        [SerializeField] float rotationSpeed = 30f;
        [SerializeField] float limitSpeed = 30f;
   
    void Update()
    {
        transform.eulerAngles = new Vector3(0,0,(Mathf.PingPong(Time.time*rotationSpeed,maxRotation))-limitSpeed);
    }
}

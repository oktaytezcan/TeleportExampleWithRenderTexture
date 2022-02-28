using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed=0.1f;
    void Start()
    {
        
    }

   
    void Update()
    {
        float xDirection= Input.GetAxis("Horizontal");
        float zDirection= Input.GetAxis("Vertical");
       
        Vector3 moveDirection = new Vector3(xDirection, 0, zDirection);
        transform.position += moveDirection * speed;




    }
}

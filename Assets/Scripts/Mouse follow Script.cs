using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousefollowScript : MonoBehaviour
{
    private bool dragging = false;
    private float distance;

    //public Rigidbody Ball;
    //public float Speed = 100;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

      //  Ball.velocity = transform.forward * Speed * Time.deltaTime;
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            distance = Vector3.Distance(transform.position, Camera.main.transform.position);
            dragging = true;
        }

        if (Input.GetMouseButtonUp(0))
        {
            dragging = false;
        }

        if (dragging)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 rayPoint = ray.GetPoint(distance);
            transform.position = new Vector3(rayPoint.x, transform.position.y, transform.position.z);
        }
    }
}

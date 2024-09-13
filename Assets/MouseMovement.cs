using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    Rigidbody2D rb;
    Vector3 destinyPoint;
    bool moving = false;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            destinyPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            destinyPoint.z = 0;
            moving = true;
        }
        if (moving)
        {
            if (Vector3.Distance(transform.position, destinyPoint) >= 0.1f)
                rb.velocity = 10.0f * (destinyPoint - transform.position);
            else
            {
                rb.velocity = new Vector3(0.0f, 0.0f, 0.0f);
                moving = false;
            }
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsMovement : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) rb.velocity = new Vector3(0.0f, 5.0f, 0.0f);
        if (Input.GetKey(KeyCode.S)) rb.velocity = new Vector3(0.0f, -5.0f, 0.0f);
        if (Input.GetKey(KeyCode.A)) rb.velocity = new Vector3(-5.0f, 0.0f, 0.0f);
        if (Input.GetKey(KeyCode.D)) rb.velocity = new Vector3(+5.0f, 0.0f, 0.0f);
    }
}

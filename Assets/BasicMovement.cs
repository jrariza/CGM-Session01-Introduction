using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) transform.position = transform.position + new Vector3(-1.0f * Time.deltaTime, 0.0f, 0.0f);
        if (Input.GetKey(KeyCode.D)) transform.position = transform.position + new Vector3(+1.0f * Time.deltaTime, 0.0f, 0.0f);
        if (Input.GetKey(KeyCode.W)) transform.position = transform.position + new Vector3(0.0f, +1.0f * Time.deltaTime, 0.0f);
        if (Input.GetKey(KeyCode.S)) transform.position = transform.position + new Vector3(0.0f, -1.0f * Time.deltaTime, 0.0f);
        if (Input.GetKey(KeyCode.Q)) transform.eulerAngles = transform.eulerAngles + new Vector3(0.0f, 0.0f, Time.deltaTime * 90.0f);
        if (Input.GetKey(KeyCode.E)) transform.eulerAngles = transform.eulerAngles + new Vector3(0.0f, 0.0f, -Time.deltaTime * 90.0f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerResponse : MonoBehaviour
{

    SpriteRenderer rd;
    Color oldColor;


    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<SpriteRenderer>();

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        oldColor = rd.color;
        rd.color = new Color(1f, 0f, 1f, 1f);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        rd.color = oldColor;
    }

    // Update is called once per frame
    void Update()
    {

    }
}

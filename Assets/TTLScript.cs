using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TTLScript : MonoBehaviour
{
    float countDown = 1.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        countDown -= Time.deltaTime;
        if (countDown <= 0.0f)
            Destroy(this.gameObject);
    }
}

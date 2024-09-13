using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnControl : MonoBehaviour
{

    [SerializeField] public GameObject pref;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject obj;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            obj = Instantiate(pref) as GameObject;
            obj.transform.position = transform.position;
        }
    }
}

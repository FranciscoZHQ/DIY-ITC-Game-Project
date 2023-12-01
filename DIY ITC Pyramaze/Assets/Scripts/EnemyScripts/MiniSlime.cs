using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MiniSlime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("l"))
        {
            makeSlimeDup();
            makeSlimeDup();
        }
    }

    public GameObject gameObject;
    public void makeSlimeDup()
    {
        GameObject mini = GameObject.Instantiate(gameObject);
        mini.transform.position = transform.position;
    }
}

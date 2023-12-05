using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        makeSlimeDup();
        makeSlimeDup();
        makeSlimeDup();
    }

    // Update is called once per frame
    void Update()
    {
        //makeSlimeDup();
    }

    public GameObject gameObject;
    public void makeSlimeDup()
    {
        GameObject mini = GameObject.Instantiate(gameObject);
        mini.transform.position = transform.position;
    }
}

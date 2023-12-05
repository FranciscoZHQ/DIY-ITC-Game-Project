using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BossBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(wait());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject gameObject;
    public void makeSlimeDup()
    {
        GameObject mini = GameObject.Instantiate(gameObject);
        mini.transform.position = transform.position;
    }

    IEnumerator waitMake()
    {
        makeSlimeDup();
        yield return new WaitForSeconds(0.1f);
        makeSlimeDup();
        yield return new WaitForSeconds(0.1f);
        makeSlimeDup();
        yield return new WaitForSeconds(0.1f);
        makeSlimeDup();
        yield return new WaitForSeconds(0.1f);
        makeSlimeDup();
        StartCoroutine(wait());
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(5.0f);
        StartCoroutine(waitMake());
    }
}

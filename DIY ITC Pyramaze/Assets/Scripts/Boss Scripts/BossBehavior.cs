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
    public GameObject gameObject2;
    public GameObject player;
    public void makeSlimeDup()
    {
        GameObject mini = GameObject.Instantiate(gameObject);
        mini.transform.position = transform.position;
    }

    

    int ranX = 0;
    int ranY = 0;
    public void makeTentDup()
    {
        ranX = Random.Range(-10, 11);
        ranY = Random.Range(-10, 11);
        GameObject tent = GameObject.Instantiate(gameObject2);
        tent.transform.position = new Vector3 (player.transform.position.x + ranX,player.transform.position.y + ranY,0);
    }

    int ran = 0;
    IEnumerator wait()
    {
        ran = Random.Range(1, 3);
        yield return new WaitForSeconds(5.0f);
        StartCoroutine(waitMake());
    }
    
    IEnumerator waitMake()
    {
        if (ran == 1)
        {
            makeSlimeDup();
            makeSlimeDup();
            makeSlimeDup();
        }
        else if (ran == 2)
        {
            makeTentDup();
        }
        yield return new WaitForSeconds(0.1f);
        if (ran == 1)
        {
            makeSlimeDup();
            makeSlimeDup();
            makeSlimeDup();
        }
        else if (ran == 2)
        {
            makeTentDup();
        }
        yield return new WaitForSeconds(0.1f);
        if (ran == 1)
        {
            makeSlimeDup();
            makeSlimeDup();
            makeSlimeDup();
        }
        else if (ran == 2)
        {
            makeTentDup();
        }
        yield return new WaitForSeconds(0.1f);
        if (ran == 1)
        {
            makeSlimeDup();
            makeSlimeDup();
            makeSlimeDup();
        }
        else if (ran == 2)
        {
            makeTentDup();
        }
        yield return new WaitForSeconds(0.1f);
        if (ran == 1)
        {
            makeSlimeDup();
            makeSlimeDup();
            makeSlimeDup();
        }
        else if (ran == 2)
        {
            makeTentDup();
        }
        StartCoroutine(wait());
    }
}

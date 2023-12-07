using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TentacleCode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waitKill());
        //Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator waitKill()
    {
        yield return new WaitForSeconds(4.0f);
        Destroy(this.gameObject);
    }
}

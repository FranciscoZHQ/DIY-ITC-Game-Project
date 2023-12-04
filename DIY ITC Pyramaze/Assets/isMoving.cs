using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isMoving : MonoBehaviour
{
    private Vector3 previousPosition;
    private bool isMovinga;

    // Start is called before the first frame update
    void Start()
    {
        previousPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position != previousPosition)
        {
            isMovinga = true;
        }
        else
        {
            isMovinga = false;
        }

        previousPosition = transform.position;
    }
}

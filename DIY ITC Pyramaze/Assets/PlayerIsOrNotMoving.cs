using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIsOrNotMoving : MonoBehaviour
{
    private Vector3 previousPosition;
    public bool isMoving;

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
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }

        previousPosition = transform.position;
    }
}

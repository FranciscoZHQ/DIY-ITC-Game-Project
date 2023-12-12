using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpRuby : MonoBehaviour
{
    GameManager gameManager;

    private bool didCountRuby = false;

    private void Start()
    {
        gameManager = GameObject.Find("Canvas").GetComponent<GameManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && !didCountRuby)
        {
            didCountRuby = true;

            gameManager.numberOfRubys++;

            Destroy(gameObject);
        }
    }
}
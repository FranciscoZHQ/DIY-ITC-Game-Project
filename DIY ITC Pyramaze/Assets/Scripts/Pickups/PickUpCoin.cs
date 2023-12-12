using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpCoin : MonoBehaviour
{
    GameManager gameManager;

    private bool didCountCoin = false;

    private void Start()
    {
        gameManager = GameObject.Find("Canvas").GetComponent<GameManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && !didCountCoin)
        {
            didCountCoin = true;

            gameManager.numberOfCoins++;

            Destroy(gameObject);
        }
    }
}
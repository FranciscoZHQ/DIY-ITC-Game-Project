using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    GameManager gameManager;

    private bool isColliding = false;

    private void Start()
    {
        gameManager = GameObject.Find("Canvas").GetComponent<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // OnTriggerEnter2D can get called a LOT, so here, if it's already 
        // colliding, we are bailing out so we don't lose health twice at the same time
        if (isColliding)
        {
            return;
        }

        if (other.gameObject.tag == "Player")
        {
            isColliding = true;

            if (gameManager.playerCurrentHealth == 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            else
            {
                other.gameObject.transform.position = gameManager.spawnPoint;
            }

            StartCoroutine(Reset());
        }
    }

    IEnumerator Reset()
    {
        yield return new WaitForSeconds(1);
        isColliding = false;
    }
}
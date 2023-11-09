using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    GameManager gameManager;
    private bool isColliding = false;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Canvas").GetComponent<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // OnTriggerEnter2D can get called a LOT, so here, if it's already 
        // colliding, we are bailing out so we don't lose 2 lives at once
        if (isColliding)
        {
            return;
        }

        if (other.gameObject.tag == "Player")
        {
            isColliding = true;

            if ()
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            else
            {
                gameManager.numberOfLives--;
                other.gameObject.transform.position = gameManager.spawnPoint;
            }

            StartCoroutine(Reset());
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public int numberOfCoins = 0;
    public int numberOfRubys = 0;

    public TextMeshProUGUI coinsText;
    public TextMeshProUGUI rubyText;

    public PlayerHealth playerHealth;

    public GameOverScreen gameOverScreen;

    public TopDownPlayer movement;

    public Vector3 spawnPoint;

    private bool isDead;



    // Start is called before the first frame update
    void Start()
    { 
        spawnPoint = new Vector3(0, 0, 0);
        
        playerHealth = GameObject.Find("PlayerPlaceHolder").GetComponent<PlayerHealth>();

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        coinsText.text = "Coins: " + numberOfCoins;
        rubyText.text = "Rubys: " + numberOfRubys;

        if (playerHealth.playerCurrentHealth <= 0 && !isDead)
        {
            isDead = true;
            movement.enabled = false;
           // GameObject.FindGameObjectWithTag("MainCamera").SetActive(true);
            Debug.Log("Dead");
            gameOverScreen.Setup();
        }

        if (gameOverScreen.gameObject.activeInHierarchy)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

   public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
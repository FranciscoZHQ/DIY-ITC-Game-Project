using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int numberOfCoins = 0;
    public int numberOfRubys = 0;
    public int numberOfPotions = 0;

    public TextMeshProUGUI coinsText;
    public TextMeshProUGUI rubyText;
    public TextMeshProUGUI potionText;

    // Other class refs.

    public PlayerHealth playerHealth;
    public GameOverScreen gameOverScreen;
    public TopDownPlayer movement;

    // End class refs.

    public Vector3 spawnPoint;

    private bool isDead;

    // Start is called before the first frame update
    void Start()
    { 
        spawnPoint = new Vector3(0, 0, 0);

        playerHealth = GameObject.Find("Protag-Kun_0").GetComponent<PlayerHealth>();
        healthbarnacle = GameObject.Find("Health Bar").GetComponent<HealthBar>();

        //Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.Locked;

        movement = GameObject.Find("Protag-Kun_0").GetComponent<TopDownPlayer>();

    }

    // Update is called once per frame
    void Update()
    {
        coinsText.text = "Coins: " + numberOfCoins;
        rubyText.text = "Rubys: " + numberOfRubys;
        potionText.text = "Potions: " + numberOfPotions;

        if (playerHealth.playerCurrentHealth <= 0 && !isDead)
        {
            isDead = true;
            movement.playerMove = false;
            // GameObject.FindGameObjectWithTag("MainCamera").SetActive(true);
            Debug.Log("Dead");
            gameOverScreen.Setup();
        }

        if (gameOverScreen.gameObject.activeInHierarchy)
        {
            //Cursor.visible = true;
            //Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            //Cursor.visible = false;
            //Cursor.lockState = CursorLockMode.Locked;
        }

        heals();
    }

    public void Restart()
    {
        SceneManager.LoadScene("PyramidLevelOne");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu Screen");
    }

    public void buyPotion()
    {
        if (numberOfCoins >= 15)
        {
            numberOfCoins -= 15;
            numberOfPotions++;
        }
    }

    public void buyWeapon()
    {
        if (numberOfRubys >= 3)
        {
            numberOfRubys -= 3;

            //if (GetComponent<SkeletonMerch>().ranATK == 1)
            //{
            //// Insert code to change weapon to gun
            //}
            //if (GetComponent<SkeletonMerch>().ranATK == 2)
            //{
            //// Insert code to change weapon to whip
            //}
            //if (GetComponent<SkeletonMerch>().ranATK == 3)
            //{
            //// Insert code to change weapon to sword
            //}
        }
    }
    public bool canDrink = true;
    HealthBar healthbarnacle;

    public void heals()
    {
        if (Input.GetKey("h"))
        {
            if (numberOfPotions >= 1 && canDrink == true)
            {
                canDrink = false;
                numberOfPotions--;

                //playerHealth.playerCurrentHealth = playerHealth.playerCurrentHealth + 20;
                //healthbarnacle.slider.value = playerHealth.playerCurrentHealth;

                if (playerHealth.playerCurrentHealth >= 80)
                {
                    playerHealth.playerCurrentHealth = playerHealth.playerMaxHealth;
                    healthbarnacle.slider.value = playerHealth.playerCurrentHealth;
                }
                else
                {
                    playerHealth.playerCurrentHealth += 20;
                    healthbarnacle.slider.value = playerHealth.playerCurrentHealth;
                }

                StartCoroutine(timerDrink());
            }
        }
    }

    IEnumerator timerDrink()
    {
        yield return new WaitForSeconds(1f);
        canDrink = true;
    }
}

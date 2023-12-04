using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int numberOfCoins = 0;
    public int numberOfRubys = 0;
    public int numberOfPotions = 0;

    public TextMeshProUGUI coinsText;
    public TextMeshProUGUI rubyText;
    public TextMeshProUGUI potionText;

    public Vector3 spawnPoint;

    // Start is called before the first frame update
    void Start()
    { 
        spawnPoint = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        coinsText.text = "Coins: " + numberOfCoins;
        rubyText.text = "Rubys: " + numberOfRubys;
        potionText.text = "Potions: " + numberOfPotions;

        if (Input.GetKey("h"))
        {
            if (numberOfPotions > 0)
            {
                numberOfPotions--;
            }
        }
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
}

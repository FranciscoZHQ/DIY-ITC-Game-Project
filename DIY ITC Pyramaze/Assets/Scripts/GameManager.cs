using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int numberOfCoins = 0;

    public TextMeshProUGUI CoinsText;

    public Vector3 spawnPoint;


    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        CoinsText.text = "Coins: " + numberOfCoins;
    }
}

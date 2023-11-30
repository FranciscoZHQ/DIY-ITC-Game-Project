using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int numberOfCoins = 0;
    public int numberOfRubys = 0;

    public TextMeshProUGUI coinsText;
    public TextMeshProUGUI rubyText;

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
    }
}

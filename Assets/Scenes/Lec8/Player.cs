using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public string playerName;
    public int health;
    private static int playerCount = 0;

    public void InitializePlayer(string name, int initialHealth)
    {
        playerName = name;
        health = initialHealth;
        playerCount++;

        Debug.Log("Player Name: " + playerName + " Health: " + health);
    }

    public void Heal(int amount)
    {
        health += amount;
        if(health > 100){
            health = 100;
        }
        Debug.Log("Current health for " + playerName + ": " + health);
    }

    public void Heal(bool fullRestore)
    {
        if (fullRestore)
        {
            health = 100;
            Debug.Log("Current health for " + playerName + ": " + health);
        }
    }

    public static void ShowPlayerCount()
    {
        Debug.Log("Player Count: " + playerCount);
    }
}

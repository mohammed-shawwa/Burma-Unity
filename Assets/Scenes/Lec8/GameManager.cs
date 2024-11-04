using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        Player p1 = new Player();
        p1.InitializePlayer("Player 1", Random.Range(0, 101));
        p1.Heal(Random.Range(5, 15));

        Player p2 = new Player();
        p2.InitializePlayer("Player 2", Random.Range(0, 101));
        p2.Heal(true);

        Player.ShowPlayerCount();
    }
}

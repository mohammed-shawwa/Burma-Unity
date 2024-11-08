namespace Lec9
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class GameManager : MonoBehaviour
    {
        void Start()
        {
            Player player = new Player("Mohammed" , 100);

            Enemy enemy = new Enemy("Ali" , 100);

            Debug.Log("Player Name: " + player.Name + " , Health: " + player.Health);
            Debug.Log("Enemy Name: " + enemy.Name + " , Health: " + enemy.Health);

            player.Heal(Random.Range(10, 30));

            enemy.Attack(player, Random.Range(10, 50));

        }
    }
}

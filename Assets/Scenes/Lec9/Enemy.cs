namespace Lec9
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Enemy : Character
    {

        public Enemy(string name, int health) : base(name, health)
        {

        }

        public void Attack(Character enemy, int damage)
        {
            enemy.Health -= damage;
            Debug.Log(Name + " attacked " + enemy.Name + " for " + damage + " damage. " + enemy.Name + " health is now " + enemy.Health);
        }
    }
}

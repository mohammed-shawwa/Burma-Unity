namespace Lec9
{

    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Player : Character
    {

        public Player(string name, int health) : base(name, health)
        {

        }

        public void Heal(int amount)
        {
            Health += amount;
            Debug.Log(Name + " healed by " + amount + ". Heath is now " + Health);
        }
    }

}
namespace Lec9
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Character
    {
        private string name;
        public string Name
        {
            get;
            set;
        }

        private int health;
        public int Health
        {
            get { return health; }
            set { if (value < 0) health = 0; else if (value > 100) health = 100; else health = value; }
        }

        public Character(string name, int health) {
            Name = name;
            Health = health;
        }
    }
}

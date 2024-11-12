using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
    public class Character
    {
        public string name;
        public int health;
        protected Position position;

        public int Health
        {
            get { return health; }
            set { if (value < 0) health = 0; else if (value > 100) health = 100; else health = value; }
        }

        public Character() : this("No name", 100, new Position(0, 0, 0))
        {

        }

        public Character(string name, int health, Position position)
        {
            this.name = name;
            Health = health;
            this.position = position;
        }

        public virtual void DisplayInfo()
        {
            Debug.Log("Your name: " + name + " , Health: " + health + " ,Position: " + position.ToString());
            // position.printPosition();
        }

        public void Attack(int damage, Character target)
        {
            MakeDamage(damage, target);
        }

        public void Attack(int damage, Character target, string attackType)
        {
            MakeDamage(damage, target);
        }

        private void MakeDamage(int damage, Character target)
        {
            target.Health -= damage;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
    public class Soldier : Character
    {
        public Soldier() : base("No name", 100, new Position(0, 0, 0))
        {

        }
        
        public Soldier(string name, int health, Position position) : base(name, health, position)
        {

        }

        public override void DisplayInfo()
        {
            Debug.Log("Soldier");
            base.DisplayInfo();
        }
    }
}

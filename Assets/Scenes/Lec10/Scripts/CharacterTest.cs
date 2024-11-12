using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
    public class CharacterTest : MonoBehaviour
    {
        void Start()
        {

            Soldier soldier = new Soldier();
            Officer officer = new Officer("Ahmed", 100, new Position(Random.Range(0, 50), 0, Random.Range(0, 25)));

            Character[] characters = { soldier, officer };

            for (int i = 0; i < characters.Length; i++)
            {
                characters[i].DisplayInfo();
            }

            Debug.Log("Soldier Health before attack: " + soldier.Health);
            Debug.Log("Officer Health before attack: " + officer.Health);

            officer.Attack(Random.Range(20, 50), soldier);
            soldier.Attack(Random.Range(20, 50), officer , "Kick");

            Debug.Log("Soldier Health after attack: " + soldier.Health);
            Debug.Log("Officer Health after attack: " + officer.Health);



        }

    }
}
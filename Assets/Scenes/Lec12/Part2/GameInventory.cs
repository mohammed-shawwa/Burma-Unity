using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lec12.Part2
{
    public class GameInventory : MonoBehaviour
    {
        void Start()
        {
            Inventory inventoryOne = new Inventory();
            inventoryOne.AddItem("Healing Potion");
            inventoryOne.AddItem("Strength Potion");

            Inventory inventoryTwo = new Inventory();
            inventoryTwo.AddItem("Elixir");
            inventoryTwo.AddItem("Dark Elixir");

            Inventory combinedInventory = inventoryOne + inventoryTwo;

            Debug.Log("Combined Inventory Items:");
            combinedInventory.ShowItems();
        }
    }
}

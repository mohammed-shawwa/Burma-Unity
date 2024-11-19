using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lec12.Part2
{
    public class Inventory
    {
        private List<string> items;

        public Inventory()
        {
            items = new List<string>();
        }

        public void AddItem(string item)
        {
            items.Add(item);
        }

        public void ShowItems()
        {
            foreach (string item in items)
            {
                Debug.Log(item);
            }
        }

        public static Inventory operator +(Inventory obj1, Inventory obj2)
        {
            Inventory temp = new Inventory();
            temp.items.AddRange(obj1.items);
            temp.items.AddRange(obj2.items);
            return temp;
        }
    }
}

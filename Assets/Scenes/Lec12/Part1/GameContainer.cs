using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lec12.Part1
{
    public class GameContainer<T>
    {
        private T item;

        public void SetItem(T item)
        {
            this.item = item;
        }

        public T GetItem()
        {
            return item;
        }
    }
}

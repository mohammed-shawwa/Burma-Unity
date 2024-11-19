using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lec12.Part1
{
    public class GenericsTest : MonoBehaviour
    {

        void Start()
        {
            GameContainer<string> container = new GameContainer<string>();
            container.SetItem("Healing Potion");

            Debug.Log("Stored item: " + container.GetItem());

            string description = GameUtils.DescribeItem(container.GetItem());
            Debug.Log(description);
        }

    }

}
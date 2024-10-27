using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment8 : MonoBehaviour
{


    void Start()
    {
        // Exercise 1
        while (true)
        {
            int rand = Random.Range(1, 21);
            if (rand == 5)
            {
                continue;
            }
            else if (rand == 15)
            {
                break;
            }
            Debug.Log("Number " + rand);
        }


        // Exercise 2
        string[] arrStr = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
        string funnySentence = "";
        int counter = 1;
        while (counter < 8)
        {
            funnySentence += arrStr[Random.Range(0, arrStr.Length)] + " ";
            counter++;
        }

        Debug.Log("Funny Sentence : " + funnySentence);

    }

}

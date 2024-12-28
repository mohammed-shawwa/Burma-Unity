using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Assignment29
{
    public class UnitySpecificScript : MonoBehaviour
    {

        void OnEnable()
        {
            Debug.Log("GameObject Enabled");
        }

        void Start()
        {
            Debug.Log("GameObject Started");

            GameObject findObject = GameObject.Find("TargetObject");
            Debug.Log(" Found object by name: " + findObject.name);

            GameObject findWithTag = GameObject.FindWithTag("Joker");
            Debug.Log(" Found object by tag: " + findWithTag.tag);

            Light light = FindObjectOfType<Light>();
            Debug.Log(" Found object by type Light: " + light.gameObject.name);


        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                Debug.Log("TargetObject deactivated!");
                gameObject.SetActive(false);
            }
        }

        void OnDisable()
        {
            Debug.Log("GameObject Disabled");
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExploionRocket : MonoBehaviour
{
    public AudioClip explosionClip;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Build")
        {
            gameObject.GetComponent<AudioSource>().clip = explosionClip;
            gameObject.GetComponent<AudioSource>().Play();

            for (int i = transform.childCount - 1; i >= 0; i--)
            {
                Destroy(transform.GetChild(i).gameObject);
            }

            // Destroy(gameObject, 3f);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Floor")
        {
            for (int i = transform.childCount - 1; i >= 0; i--)
            {
                Destroy(transform.GetChild(i).gameObject);
            }

        }
    }
}

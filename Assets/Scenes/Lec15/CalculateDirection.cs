using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateDirection : MonoBehaviour
{

    public GameObject player;
    public float speed = 3f;

    void Start()
    {

    }


    void Update()
    {
        // Direction = Destination - source
        Vector3 direction = player.transform.position - transform.position;
        direction.Normalize();
        Debug.Log("Magnitude: " + direction.magnitude);
        Debug.DrawRay(transform.position, player.transform.position, Color.green);

        transform.Translate(direction * Time.deltaTime * speed);
    }
}

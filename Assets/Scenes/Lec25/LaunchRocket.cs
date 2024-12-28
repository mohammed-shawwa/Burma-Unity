using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LaunchRocket : MonoBehaviour
{

    public GameObject[] rockets;
    public Transform areaCenter;
    public Vector3 areaSize;
    public float launchAngle = 45f;

    private int index = 0;

    void Start()
    {

    }

    Vector3 GetRandomPointInArea()
    {
        float randomX = Random.Range(-areaSize.x / 2, areaSize.x / 2);
        float randomY = Random.Range(-areaSize.y / 2, areaSize.y / 2);
        float randomZ = Random.Range(-areaSize.z / 2, areaSize.z / 2);
        return areaCenter.position + new Vector3(randomX, randomY, randomZ);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && index < rockets.Length)
        {
            Vector3 targetPoint = GetRandomPointInArea();
            Vector3 direction = targetPoint - rockets[index].transform.position;

            float horizontalDistance = new Vector3(direction.x, 0, direction.z).magnitude;
            float verticalDistance = direction.y;

            float angleInRadians = launchAngle * Mathf.Deg2Rad;

            float gravity = Physics.gravity.y;
            float initialVelocity = Mathf.Sqrt((horizontalDistance * -gravity) /
                            (Mathf.Sin(2 * angleInRadians) - 2 * verticalDistance / horizontalDistance));


            float velocityX = initialVelocity * Mathf.Cos(angleInRadians);
            float velocityY = initialVelocity * Mathf.Sin(angleInRadians);


            Rigidbody rb = rockets[index].GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.isKinematic = false;
                Vector3 velocity = new Vector3(direction.x, 0, direction.z).normalized * velocityX;
                velocity.y = velocityY;
                rb.velocity = velocity;

                rockets[index].GetComponent<Rigidbody>().GetComponent<AudioSource>().Play();
            }

            index++;
        }

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(255, 0, 0);
        Gizmos.DrawCube(areaCenter.position, areaSize);
    }
}

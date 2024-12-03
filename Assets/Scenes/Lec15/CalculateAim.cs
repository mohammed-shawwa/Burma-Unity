using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculateAim : MonoBehaviour
{

    public float speed = 3f;

    void Start()
    {

    }


    void Update()
    {



        // Direction = Destination - source
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));

        Vector3 direction = mousePosition - transform.position;
        // direction.Normalize();
        Debug.DrawRay(transform.position, mousePosition, Color.green);


        // Mathf.Deg2Rad تستخدم مع sig , cos لانو بتطلب تكون الزوايا بوحدة الراديان
        // Mathf.Rad2Deg  تستخدم مع Atan, Asin, Acos لتحويل من ريديان لدرجة

        // قمنا بطرح 90 لانو نظام الاحداثي في اليونتي يختلف عن النظام الاحداثي في الرياضيات
        // في رياضيات الزاوية صفر تقطع في محور x
        // والزاوية بتزيد في العكس عقارب الساعة 

        // في اليونتي تعتبر الزواية صفر عند الحور y
        // الوزاية بتزيد عكس عقارب الساعة لكن الزاوية المرجعية الاساس الها محور y

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90;

        Quaternion angleAxis = Quaternion.AngleAxis(angle, Vector3.forward);

        transform.rotation = Quaternion.Slerp(transform.rotation, angleAxis, Time.deltaTime * 3);
    }
}

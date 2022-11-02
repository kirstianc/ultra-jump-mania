using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointTowards : MonoBehaviour
{
    public float speed = 5f;
    public Transform target;

    void Update()
    {
        Vector2 direction = target.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x)*Mathf.Rad2Deg;
        Quaternion rotation=Quaternion.AngleAxis(angle+270, Vector3.forward);
        transform.rotation=Quaternion.Slerp(transform.rotation,rotation,speed*Time.deltaTime);
    }
}

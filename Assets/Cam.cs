using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public float speed = 10.0f;
    public Transform target;


    void Update()
    {
        Vector3 newPos = new Vector3(target.position.x, target.position.y, -100);
        transform.position = Vector3.Slerp(transform.position, newPos, speed * Time.deltaTime);
    }
}

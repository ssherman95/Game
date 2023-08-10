using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public static float speed = 5;
    //public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        GameObject target = GameObject.Find("Elf");
        transform.rotation = Quaternion.LookRotation(transform.forward, target.transform.position - transform.position);
        GetComponent<Rigidbody2D>().velocity = transform.up * speed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Wall")
        {
            Destroy(this.gameObject, .25f);
        }
        if (other.tag == "Elf")
        {
            Destroy(this.gameObject, .25f);
            GameController.gameController.takeDamage();
        }
    }
}

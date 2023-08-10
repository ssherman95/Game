using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject projectilePrefab;
    public GameObject target;


    void Start()
    {
        shootStuff();
    }

    void shootStuff()
    {
        StartCoroutine(ShootStuffRoutine());
        IEnumerator ShootStuffRoutine()
        {
            while (true)
            {
                yield return null;
                Instantiate(projectilePrefab, transform.position, Quaternion.identity);
                yield return new WaitForSeconds(2f);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet")
        {
            Destroy(other, .25f);
            Destroy(this.gameObject, .25f);
        }
    }
}

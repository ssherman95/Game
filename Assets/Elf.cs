using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Elf : MonoBehaviour
{
    public float speed = 10.0f;

    public GameObject projectilePrefab;

    List<GameObject> pool;
    int poolMax = 10;

    SpriteRenderer sr;
    Rigidbody2D rb;

    void Awake()
    {
        pool = new List<GameObject>();
        Debug.Log("Awake Called!");
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    public void Move(Vector3 direction)
    {
        rb.MovePosition(transform.position + (direction * speed * Time.fixedDeltaTime));
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Arrow")
        {
            GetComponent<AudioSource>().Play();
        }
        if (other.tag == "Stairs" && GameController.gameController.hasKey())
        {
            SceneManager.LoadScene("Level2");
        }
    }

    public void LaunchProjectile()
    {
        GameObject newProjectile;
        if (pool.Count >= poolMax)
        {
            newProjectile = pool[0];
            newProjectile.transform.position = transform.position;
            pool.RemoveAt(0);
        }
        else
        {
            newProjectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        }
        pool.Add(newProjectile);
    }
}

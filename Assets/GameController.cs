using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{
    public int health = 100;
    public bool key = false;
    public int ammo = 0;

    public static GameController gameController = null;

    // Start is called before the first frame update
    void Awake()
    {
        if (gameController == null)
        {
            gameController = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void takeDamage()
    {
        health = health - 25;
        if (health <= 0)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    public void drinkPotion()
    {
        health = health + 50;
        if(health > 100)
        {
            health = 100;
        }
    }

    public void pickUpKey()
    {
        key = true;
    }

    public bool hasKey()
    {
        if(key == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void pickUpAmmo()
    {
        ammo++;
    }

    public void shootAmmo()
    {
        GetComponent<AudioSource>().Play();
        ammo--;
        if(ammo < 0)
        {
            ammo = 0;
        }
    }

    public bool hasAmmo()
    {
        if (ammo > 0)
        {
            shootAmmo();
            return true;
        }
        else
        {
            return false;
        }
    }
}

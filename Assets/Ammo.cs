using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Elf")
        {
            GetComponent<AudioSource>().Play();
            GameController.gameController.pickUpAmmo();
            Destroy(this.gameObject, .5f);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Elf")
        {
            GetComponent<AudioSource>().Play();
            GameController.gameController.pickUpKey();
            Destroy(this.gameObject, .25f);
        }
    }
}

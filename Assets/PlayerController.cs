using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Elf elf;
    bool hasAmmo = false;

    void Awake()
    {
        elf = GetComponent<Elf>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse1))
        {
            hasAmmo = GameController.gameController.hasAmmo();
            if (hasAmmo)
            {
                elf.LaunchProjectile();

            }
        }
    }

    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.D))
        {
            elf.Move(new Vector3(1, 0, 0));
        }
        else if (Input.GetKey(KeyCode.A))
        {
            elf.Move(new Vector3(-1, 0, 0));
        }
        else if (Input.GetKey(KeyCode.W))
        {
            elf.Move(new Vector3(0, 1, 0));
        }
        else if (Input.GetKey(KeyCode.S))
        {
            elf.Move(new Vector3(0, -1, 0));
        }

    }
}

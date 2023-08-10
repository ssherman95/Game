using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AmmoCount : MonoBehaviour
{
    public Text textElement;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        textElement.text = GameController.gameController.ammo.ToString();
    }
}

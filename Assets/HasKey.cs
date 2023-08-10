using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HasKey : MonoBehaviour
{
    Image m_Image;
    public Sprite sprite;

    // Start is called before the first frame update
    void Start()
    {
        m_Image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.gameController.hasKey())
        {
            m_Image.sprite = sprite;
        }
    }
}

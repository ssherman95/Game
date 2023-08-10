using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioSlider : MonoBehaviour
{
    public AudioSource myAudio;
    float mySliderValue;

    // Start is called before the first frame update
    void Start()
    {
        mySliderValue = 0.25f;
        myAudio = GetComponent<AudioSource>();
        myAudio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI()
    {
        mySliderValue = GUI.HorizontalSlider(new Rect(150, 27, 200, 60), mySliderValue, 0.0F, 1.0F);
        myAudio.volume = mySliderValue;
    }
}

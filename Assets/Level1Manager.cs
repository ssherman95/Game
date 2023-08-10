using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Level1Manager : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenu;
    [SerializeField] private GameObject _pausebutton;
    public AudioSource myAudio;
    public Texture2D cursorAim;
    float mySliderValue;

    public void Start()
    {
        Vector2 cursorOffset = new Vector2(cursorAim.width / 2, cursorAim.height / 2);
        Cursor.SetCursor(cursorAim, cursorOffset, CursorMode.ForceSoftware);
        Time.timeScale = 1.0f;
        _pauseMenu.SetActive(false);
        _pausebutton.SetActive(true);
    }

    public void QuiteGame()
    {
        Application.Quit();
    }

    public void Menu(string MainMenu)
    {
        SceneManager.LoadScene(MainMenu);
    }

    public void PauseButton()
    {
        Time.timeScale = 0f;
        _pauseMenu.SetActive(true);
        _pausebutton.SetActive(false);
    }

    public void ResumeButton()
    {
        Time.timeScale = 1.0f;
        _pauseMenu.SetActive(false);
        _pausebutton.SetActive(true);
    }

    public void ChangeScene(string Level2)
    {
        SceneManager.LoadScene(Level2);
    }

    

}

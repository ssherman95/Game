using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    public void ChangeScene(string Level1)
    {
        SceneManager.LoadScene(Level1);
    }

    public void Exit()
    {
        Application.Quit();
    }
}

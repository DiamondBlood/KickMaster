using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public void ChangeSceneMainMenu()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
    public void ChangeSceneLvl1()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Lvl1", LoadSceneMode.Single);
    }
    public void Exit()
    {
        Application.Quit();
    }
}

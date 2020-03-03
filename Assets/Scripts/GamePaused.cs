using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GamePaused : MonoBehaviour
{
    void Start()
    {
        GlobalGM.Instance.isPaused = false;
    }

    public void ContinuePlaying()
    {
        GlobalGM.Instance.playClick();
        SceneManager.LoadScene("Level0"+GlobalGM.Instance.levelPaused);
    }

    public void ExitGame()
    {
        GlobalGM.Instance.playClick();
        Application.Quit();
    }

    public void MainMenu()
    {
        GlobalGM.Instance.playClick();
        SceneManager.LoadScene("MainMenu");
    }
}

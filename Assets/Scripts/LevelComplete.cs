using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelComplete : MonoBehaviour
{
    public Button nextLevelButton, exitButton, openLevelSelectButton;
    private int lastLevelIndex;

    public void OpenNextLevel()
    {
        GlobalGM.Instance.playClick();
        if (GlobalGM.Instance.currentLevel == 9)
        {
            Debug.Log("Endless mode!");
            SceneManager.LoadScene("EndlessMode");
        }
        else
        {
            SceneManager.LoadScene("Level0" + (GlobalGM.Instance.currentLevel + 1));
        }
        
    }

    public void OpenLevelSelect()
    {
        GlobalGM.Instance.playClick();
        SceneManager.LoadScene("LevelSelect");
    }

    public void Exit()
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

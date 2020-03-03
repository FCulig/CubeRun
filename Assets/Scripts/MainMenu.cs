using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void Start()
    {
        
    }

    public void StartGame()
    {
        GlobalGM.Instance.playClick();
        SceneManager.LoadScene("Level0" + GlobalGM.Instance.currentLevel);
    }

    public void OpenLevelSelect()
    {
        GlobalGM.Instance.playClick();
        SceneManager.LoadScene("LevelSelect");
    }

    public void OpenOptions()
    {
        GlobalGM.Instance.playClick();
        SceneManager.LoadScene("Options");
    }

    public void StartEndlessMode()
    {
        GlobalGM.Instance.playClick();
        SceneManager.LoadScene("EndlessMode");
    
    }

    public void ExitGame()
    {
        GlobalGM.Instance.playClick();
        Application.Quit();
    }
}

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float delayRestart = 1f;
    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        GlobalGM.Instance.currentLevel = SceneManager.GetActiveScene().buildIndex;
        FindObjectOfType<Fade>().FadeToScene();
    }

    public void GameOver()
    {
        gameHasEnded = true;
        if (gameHasEnded)
        {
            if (SceneManager.GetActiveScene().name.Equals("EndlessMode"))
            {
                EndlessDeath();
            }
            else
            {
                Invoke("Restart", delayRestart);
            }
            
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void EndlessDeath()
    {
        SceneManager.LoadScene("GameEndedEndless");
    }
    
}

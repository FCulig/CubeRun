using UnityEngine;
using UnityEngine.SceneManagement;

public class Fade : MonoBehaviour
{
    public Animator animator;

    private void Update()
    {
        if (SceneManager.GetActiveScene().name != "EndlessMode")
        {
            if (FindObjectOfType<EndTrigger>().isTriggered == true)
            {
                FindObjectOfType<GameManager>().CompleteLevel();
            }
        }
    }

    public void FadeToScene ()
    {
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeComplete()
    {
        if(GlobalGM.Instance.isPaused == true)
        {
            GlobalGM.Instance.isPaused = false;
            SceneManager.LoadScene("GamePaused");
        }
        else
        {
            SceneManager.LoadScene("LevelComplete");
        }
    }
}

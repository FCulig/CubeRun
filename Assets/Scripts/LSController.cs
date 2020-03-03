using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LSController : MonoBehaviour
{
    int lastLevel;
    public Button[] lv = new Button[8];
    public Sprite lockedImage;


    void Start()
    {
        lastLevel = GlobalGM.Instance.currentLevel + 1;

        if(lastLevel == 2)
        {
            lastLevel = 1;
        }

        for (int i = lastLevel; i < lv.Length; i++)
        {
            lv[i].interactable = false;
            lv[i].GetComponentInChildren<Text>().text = " ";
            lv[i].GetComponentInChildren<Image>().sprite = lockedImage;
        }
    }

    public void MainMenu()
    {
        GlobalGM.Instance.playClick();
        SceneManager.LoadScene("MainMenu");
    }

    public void OpenLevel(int level)
    {
        GlobalGM.Instance.playClick();
        SceneManager.LoadScene("Level0" + level);
    }
}

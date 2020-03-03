using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour
{

    public Button muteUnmuteButton;
    public Sprite muted;
    public Sprite unmuted;

    public Slider volumeSlider;

    void Start()
    {
        if (GlobalGM.Instance.buttonClicks)
        {
            setUnmutedIcon();
        }
        else
        {
            setMutedIcon();
        }

        volumeSlider.value = GlobalGM.Instance.endlessMusicVolume;
    }

    public void OpenMainMenu() {
        GlobalGM.Instance.playClick();
        SceneManager.LoadScene("MainMenu");
    }

    public void buttonClicks()
    {
        if (GlobalGM.Instance.buttonClicks)
        {
            setMutedIcon();
            GlobalGM.Instance.buttonClicks = false;
        }
        else
        {
            GlobalGM.Instance.playClick();
            setUnmutedIcon();
            GlobalGM.Instance.buttonClicks = true;
        }
    }

    public void endlessModeMusic()
    {
        GlobalGM.Instance.endlessMusicVolume = volumeSlider.value;
    }

    private void setMutedIcon()
    {
        muteUnmuteButton.GetComponent<Image>().sprite = muted;
    }

    private void setUnmutedIcon()
    {
        muteUnmuteButton.GetComponent<Image>().sprite = unmuted;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class EndlessEndScreen : MonoBehaviour
{
    public Text scoreText;

    public GameObject popup;
    public InputField username;

    private void Awake()
    {
        popup.SetActive(false);
    }

    void Start()
    {
        setScoreText();

        if (isInLeaderboards())
        {
            popup.SetActive(true);
        }
    }

    public void PlayAgain()
    {
        GlobalGM.Instance.playClick();
        SceneManager.LoadScene("EndlessMode");
    }

    public void Leaderboard()
    {
        GlobalGM.Instance.playClick();
        SceneManager.LoadScene("Leaderboard");
    }

    public void ClosePopup()
    {
        GlobalGM.Instance.playClick();
        popup.SetActive(false);
    }

    public void SubmitScore()
    {
        GlobalGM.Instance.playClick();
        StartCoroutine(PostScore());
        popup.SetActive(false);
        GlobalGM.Instance.endlessScore = "0";
    }

    private IEnumerator PostScore()
    {
        string name = username.text;
        int score = int.Parse(GlobalGM.Instance.endlessScore);

        WWW www;
        Hashtable postHeader = new Hashtable();
        postHeader.Add("Content-Type", "application/json");

        var formData = System.Text.Encoding.UTF8.GetBytes("{\"name\":\"" + name + "\", \"score\":"+ score + "}");

        www = new WWW("https://rri-server.herokuapp.com/api/scores", formData, postHeader);

        yield return www;
        if (www.error != null)
        {
            Debug.Log("There was an error sending request: " + www.error);
        }
    }

    private void setScoreText()
    {
        scoreText.text = GlobalGM.Instance.scoreToDisplay;
    }

    private bool isInLeaderboards()
    {
        if(int.Parse(GlobalGM.Instance.endlessScore) > GlobalGM.Instance.GetLeaderboardMinScore())
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

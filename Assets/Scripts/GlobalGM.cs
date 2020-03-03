using System.Net;
using System.IO;
using UnityEngine;

public class GlobalGM : MonoBehaviour
{
    private const string API_URL = "https://rri-server.herokuapp.com/api/scores";

    public static GlobalGM Instance { get; private set; }

    public AudioSource audioSource;

    public int currentLevel;
    public bool isPaused;
    public int levelPaused;

    public bool buttonClicks;
    public float endlessMusicVolume;

    public string endlessScore;
    public string scoreToDisplay;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

            currentLevel = 1;

            isPaused = false;
            levelPaused = 1;

            buttonClicks = true;
            endlessMusicVolume = 1;

        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void playClick()
    {
        if (buttonClicks)
        {
            audioSource.Play();
        }
    }

    public LeaderboardScores GetScores()
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(API_URL);
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string jsonResponse = reader.ReadToEnd();
        LeaderboardScores scores = JsonUtility.FromJson<LeaderboardScores>("{\"scores\":" + jsonResponse + "}");
        return scores;
    }

    public int GetLeaderboardMinScore()
    {
        return GetScores().scores[4].score;
    }
}

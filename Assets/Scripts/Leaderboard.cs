using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

using System.Net;
using System.IO;

public class Leaderboard : MonoBehaviour
{
     public List<Text> names;
    public List<Text> scores;

    private LeaderboardScores leaderboard;

    void Awake()
    {
        leaderboard = GlobalGM.Instance.GetScores();
    }

    void Start()
    {
        fillLeaderboard();
    }

    public void Back()
    {
        GlobalGM.Instance.playClick();
        SceneManager.LoadScene("GameEndedEndless");
    }

    private void fillLeaderboard()
    {
        for(int i = 0; i < 5; i++)
        {
            names[i].text = leaderboard.scores[i].name;
            scores[i].text = leaderboard.scores[i].score.ToString();
        }
    }
}




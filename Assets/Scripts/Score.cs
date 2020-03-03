using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
        GlobalGM.Instance.endlessScore = scoreText.text;
        GlobalGM.Instance.scoreToDisplay = scoreText.text;
    }
}

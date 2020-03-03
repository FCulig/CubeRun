using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class LeaderboardScore
{
    public int score;
    public string name;

    public LeaderboardScore(int s, string n)
    {
        score = s;
        name = n;
    }
}

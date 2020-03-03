using System;
using System.Collections.Generic;

[Serializable]
public class LeaderboardScores
{
    public LeaderboardScore[] scores;

    public override string ToString()
    {
        string res = "";

        foreach(LeaderboardScore sc in scores){
            res = res + sc.name;
        }

        return res;
    }
}

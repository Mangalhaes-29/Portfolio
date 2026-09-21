using UnityEngine;
using System.Collections.Generic;

public class ScoreManager : MonoBehaviour
{
    public int topScore = 0;
    public int bottomScore = 0;

    public int currentHits = 0;
    public int bestHits = 0;

    public List<string> matchHistory = new List<string>();

    void Start()
    {
        bestHits = PlayerPrefs.GetInt("BestHits", 0);
    }

    public void BallHit()
    {
        currentHits++;

        Debug.Log("HITS: " + currentHits);

        if (currentHits > bestHits)
        {
            bestHits = currentHits;

            PlayerPrefs.SetInt("BestHits", bestHits);

            PlayerPrefs.Save();
        }
    }

    public void GoalScored()
    {
        currentHits = 0;

        if (bottomScore >= 5 || topScore >= 5)
        {
            string result =
                topScore + "-" + bottomScore +
                " | " + bestHits + " toques";

            matchHistory.Insert(0, result);

            if (matchHistory.Count > 3)
                matchHistory.RemoveAt(3);

            topScore = 0;
            bottomScore = 0;
        }
    }

    void SaveMatch()
    {
        string result = topScore + "-" + bottomScore + " | " + currentHits + " toques";

        matchHistory.Insert(0, result);

        if (matchHistory.Count > 3)
            matchHistory.RemoveAt(3);
    }
}   
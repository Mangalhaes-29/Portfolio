using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI hitsText;
    public TextMeshProUGUI bestText;

    public TextMeshProUGUI[] historyTexts;

    public ScoreManager scoreManager;

    void Start()
    {
        scoreText.text = "FUNCIONA";
    }

    void Update()
    {
        scoreText.text =
            scoreManager.bottomScore + " - " + scoreManager.topScore;

        hitsText.text =
            "Hits: " + scoreManager.currentHits;

        bestText.text =
            "Best: " + scoreManager.bestHits;

        for (int i = 0; i < historyTexts.Length; i++)
        {
            if (i < scoreManager.matchHistory.Count)
                historyTexts[i].text = scoreManager.matchHistory[i];
            else
                historyTexts[i].text = "";
        }
    }
}
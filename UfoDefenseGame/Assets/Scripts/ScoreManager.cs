using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score; // keep score value
    public TextMeshProUGUI scoreText; // visual text is modified
    
    public void IncreaseScore(int amount) // increase by set amount
    {
        score += amount;
        UpdateScoreText();
    }
    
    public void DecreaseScore(int amount) // decrease by set
    {
        score -= amount;
        UpdateScoreText();
    }

    void UpdateScoreText() // updates score in hud text
    {
        scoreText.text = "Score: " + score;
    }
}

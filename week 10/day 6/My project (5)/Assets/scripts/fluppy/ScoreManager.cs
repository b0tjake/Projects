using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText; // Add this for the Menu
    private int score = 0;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        // Update the high score display at the start
        UpdateHighScoreUI();
    }

    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
        
        // Check if we just beat the high score in real-time
        if (score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
            UpdateHighScoreUI();
        }
    }

    void UpdateHighScoreUI()
    {
        if (highScoreText != null)
        {
            highScoreText.text = "Best: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
        }
    }
}
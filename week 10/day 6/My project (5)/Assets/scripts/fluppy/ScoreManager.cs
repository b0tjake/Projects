using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI scoreText;
    private int score = 0;

    void Awake()
    {
        // This allows other scripts to find the ScoreManager easily
        instance = this;
    }

    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
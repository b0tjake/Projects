using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverMenu; // Drag your Panel/Menu here
    public TextMeshProUGUI finalScoreText; // The text inside the gold frame

    void Start()
    {
        // Make sure the menu is hidden when the game starts
        gameOverMenu.SetActive(false);
    }

   public void ShowGameOver(int score)
{
    gameOverMenu.SetActive(true);
    
    // Pull the saved high score
    int currentHighScore = PlayerPrefs.GetInt("HighScore", 0);

    // Display both on your menu
    // Assuming you have one text for current and one for best
    finalScoreText.text = "Score: " + score;
    
    // If you have a separate text for high score on the menu:
    // highScoreMenuText.text = "Best: " + currentHighScore;

    Time.timeScale = 0f; 
}

    public void ReplayGame()
    {
        // Reset time before loading
        Time.timeScale = 1f; 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
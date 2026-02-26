using UnityEngine;
using UnityEngine.SceneManagement;

public class GameFlowFacade : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
    }

    public void EndGame()
    {
        Debug.Log("Game Over");
    }
}
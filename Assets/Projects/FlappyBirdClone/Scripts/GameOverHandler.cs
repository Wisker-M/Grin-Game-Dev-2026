using UnityEngine;
using UnityEngine.SceneManagement;
namespace FlappyBirdClone
{
public class GameOverHandler : MonoBehaviour
{
    public GameObject gameOverUI;

    private void Start()
    {
        if (gameOverUI != null)
        {
            gameOverUI.SetActive(false);
        }
        
        if (Projects.MegaSuperChallengeShot.Scripts.ScoreManager.Instance != null)
        {
            Projects.MegaSuperChallengeShot.Scripts.ScoreManager.Instance.SetTextVisibility(true);
        }
    }

    public void ShowGameOver()
    {
        if (gameOverUI != null)
        {
            gameOverUI.SetActive(true);
            
            if (Projects.MegaSuperChallengeShot.Scripts.ScoreManager.Instance != null)
            {
                Projects.MegaSuperChallengeShot.Scripts.ScoreManager.Instance.SetTextVisibility(false);
            }

            var textComp = gameOverUI.GetComponent<UnityEngine.UI.Text>();
            if (textComp != null)
            {
                int currentScore = 0;
                if (Projects.MegaSuperChallengeShot.Scripts.ScoreManager.Instance != null)
                {
                    currentScore = Projects.MegaSuperChallengeShot.Scripts.ScoreManager.Instance.Score;
                }

                int bestScore = PlayerPrefs.GetInt("BestScore", 0);
                if (currentScore > bestScore)
                {
                    bestScore = currentScore;
                    PlayerPrefs.SetInt("BestScore", bestScore);
                    PlayerPrefs.Save();
                }

                textComp.text = $"GAME OVER\nScore: {currentScore}\nBest: {bestScore}\n\nPress R to Restart";
            }
        }
        Time.timeScale = 0f;
    }

    private void Update()
    {
        if (Time.timeScale == 0f && Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}

}
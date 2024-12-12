using UnityEngine;
using TMPro; // Include if using TextMeshPro

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Reference to the Score Text UI
    private int score = 0; // Initial score

    // Method to add points
    public void AddScore(int points)
    {
        score += points;
        UpdateScoreUI();
    }

    // Method to deduct points
    public void DeductScore(int points)
    {
        score -= points;
        UpdateScoreUI();
    }

    // Update the Score UI
    private void UpdateScoreUI()
    {
        scoreText.text = "Score: " + score;
    }
}

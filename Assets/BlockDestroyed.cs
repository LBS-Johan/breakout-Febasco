using UnityEngine;

public class Block : MonoBehaviour
{
    public int points = 10; // Points awarded for destroying this block

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            // Add points to the score
            GameManager gameManager = FindObjectOfType<GameManager>();
            if (gameManager != null)
            {
                gameManager.AddScore(points);
            }

            // Destroy the block
            Destroy(gameObject);
        }
    }
}

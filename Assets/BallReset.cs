using UnityEngine;

public class BallReset : MonoBehaviour
{
    public float respawnSpeed = 2f; // Speed of the ball moving downward after respawn

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (transform.position.y < -6)
        {
            // Reset the ball's position
            transform.position = new Vector2(0, 0);

            // Set the ball's velocity to move downward
            if (rb != null)
            {
                rb.velocity = Vector2.down * respawnSpeed;
            }

            // Deduct points
            GameManager gameManager = FindObjectOfType<GameManager>();
            if (gameManager != null)
            {
                gameManager.DeductScore(20);
            }
        }
    }
}

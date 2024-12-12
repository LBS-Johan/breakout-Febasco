using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody2D myRigidbody; // The ball's Rigidbody2D
    public float initialSpeed = 2f; // The starting speed of the ball
    public float maxSpeed = 10f; // The maximum speed of the ball
    public float acceleration = 0.1f; // Speed increase over time
    private float currentSpeed; // Tracks the current speed of the ball

    void Start()
    {
        // Set the initial speed
        currentSpeed = initialSpeed;

        // Launch the ball in a random initial direction
        Vector2 initialDirection = new Vector2(Random.Range(-1f, 1f), -1f).normalized;
        myRigidbody.velocity = initialDirection * currentSpeed;
    }

    void Update()
    {
        // Gradually increase speed over time, up to the max speed
        if (currentSpeed < maxSpeed)
        {
            currentSpeed += acceleration * Time.deltaTime;
        }

        // Normalize the velocity to maintain consistent speed
        myRigidbody.velocity = myRigidbody.velocity.normalized * currentSpeed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Add slight adjustments to avoid pure vertical or horizontal movement
        Vector2 direction = myRigidbody.velocity;

        if (Mathf.Abs(direction.x) < 0.1f)
        {
            direction.x += (direction.x > 0 ? 0.1f : -0.1f);
        }

        if (Mathf.Abs(direction.y) < 0.1f)
        {
            direction.y += (direction.y > 0 ? 0.1f : -0.1f);
        }

        myRigidbody.velocity = direction.normalized * currentSpeed;
    }
}

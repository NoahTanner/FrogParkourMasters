using UnityEngine;

public class PlayerJumpOver : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        // Assuming 'other' is the player you might jump over
        if (IsJumpingOverPlayer()) // You need to implement this method based on your jump logic
        {
            gameManager.UpdateScore(gameObject.name);
        }
    }

    private bool IsJumpingOverPlayer()
    {
        // Implement your jump detection logic here
        // For example, check if the player's Y position is above a certain threshold or use a boolean that tracks the jump state
        return true; // Placeholder
    }
}

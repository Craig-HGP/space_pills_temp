using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private PauseManager pauseManager;

    private void Start()
    {
        pauseManager = FindObjectOfType<PauseManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Pause the game when the enemy collides with the player
            pauseManager.PauseGame();
        }
    }
}

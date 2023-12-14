using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    public float moveSpeed; // This variable will store the moveSpeed value
    RandomYRotation rotate;

    private void OnCollisionEnter(Collision collision)
    {
        //Check if the collided object is tagged as "Wall"
        if (collision.gameObject.CompareTag("Wall") || collision.gameObject.CompareTag("Enemy"))
        {
          

            // Calculate the bounce direction away from the wall
            Vector3 bounceDirection = Vector3.Reflect(transform.forward, collision.contacts[0].normal).normalized;

            // Apply a force to bounce the enemy
            Rigidbody rb = GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.velocity = bounceDirection * moveSpeed; // Access moveSpeed here
            }
        }
    }
}

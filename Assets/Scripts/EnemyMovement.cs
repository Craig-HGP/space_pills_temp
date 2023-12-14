using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust this speed as needed
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        // Start moving the enemy in a specific direction (e.g., forward)
        rb.velocity = transform.forward * moveSpeed;
    }
}

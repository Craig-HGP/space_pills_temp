using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float moveSpeed = 20f;
    private Rigidbody rb;
    private Vector3 normal;
    private Vector3 bounceDirection;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0,moveSpeed,0); // Initial movement direction

    }

    private void Update()
    {
         transform.Translate(bounceDirection * moveSpeed * Time.deltaTime);
    }
    

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object is tagged as "Wall"
        if (collision.gameObject.CompareTag("Wall"))
        {
            // Calculate the bounce direction away from the wall
            normal = collision.contacts[0].normal;
            bounceDirection = Vector3.Reflect(rb.velocity, normal);

          
            // Change the movement direction to the new bounce direction
            rb.velocity = bounceDirection;
        }
    }
}




    using UnityEngine;

public class Raycasting : MonoBehaviour
{
    public float moveSpeed = 5f;

    private void Update()
    {
        // Get the desired movement direction
        Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;

        // Perform raycasting to check for collisions
        RaycastHit hit;
        if (Physics.Raycast(transform.position, moveDirection, out hit, moveSpeed * Time.deltaTime))
        {
            // Collision detected, prevent movement in this direction
            moveDirection = Vector3.zero;
        }

        // Move the character
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}


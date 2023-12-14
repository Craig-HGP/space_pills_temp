using UnityEngine;

public class RandomYRotation : MonoBehaviour
{
    private float randomYRotation;
    
    private void Start()
    {}     

    private void Update()
    {
        EnemyRotate();
    }

    public void EnemyRotate()
    {
        // Generate a random rotation angle around the Y-axis (0-360 degrees)
        randomYRotation = Random.Range(0f, 360f);

        // Create a Quaternion for the random Y-axis rotation
        Quaternion randomRotation = Quaternion.Euler(0f, randomYRotation, 0f);

        // Apply the random Y-axis rotation to the enemy
        transform.rotation = randomRotation;
    }
}

using UnityEngine;

public class MusicController : MonoBehaviour
{
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        // Play the background music
        audioSource.Play();
    }
}

using UnityEngine;
using TMPro;

public class CountUpTimer : MonoBehaviour
{
    public TextMeshProUGUI timerText; // Reference to the TMP Text element
    private float currentTime = 0f;

    private void Update()
    {
        // Update the timer (counts up)
        currentTime += Time.deltaTime;

        // Update the TMP Text to display the timer
        if (timerText != null)
        {
            // Format the time as needed (e.g., displaying it as seconds with two decimal places)
            timerText.text = currentTime.ToString("F2");
        }
    }
}

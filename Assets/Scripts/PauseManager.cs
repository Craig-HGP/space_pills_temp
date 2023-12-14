using UnityEngine;

public class PauseManager : MonoBehaviour
{
    private bool isPaused = false;

    public void PauseGame()
    {
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void UnpauseGame()
    {
        Time.timeScale = 1f;
        isPaused = false;
    }

    public bool IsGamePaused()
    {
        return isPaused;
    }
}




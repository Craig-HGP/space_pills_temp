using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject pauseMenu;
    public PauseManager pauseManager;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !pauseManager.IsGamePaused())
        {
            pauseManager.PauseGame();
            pauseMenu.SetActive(true);
        }
    }

    public void ResumeGame()
    {
        pauseManager.UnpauseGame();
        pauseMenu.SetActive(false);
    }
}


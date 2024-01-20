using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Singleton instance
    public static GameManager Instance { get; private set; }

    private void Start()
    {
        Time.timeScale = 1f;
    }

    private void Awake()
    {
        // Ensure that there's only one instance of this object in the game
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void ReloadLevel()
    {
        Time.timeScale = 1f; // Ensure that the game's time is running normally
        PlayerState.Instance.ResetDeathState(); // Reset the player's death state
        
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
    
}
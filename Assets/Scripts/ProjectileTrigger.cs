using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene management

public class ProjectileTrigger : MonoBehaviour
{
    public GameObject deathScreen;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("PlayerDeath");
            PlayerState.Instance.SetPlayerDeathState(true);
            ShowDeathScreen();
        }
    }

    private void ShowDeathScreen()
    {
        Time.timeScale = 0f; 
        deathScreen.SetActive(true);
    }
    
    public void ReloadLevel()
    {
        Time.timeScale = 1f; 
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
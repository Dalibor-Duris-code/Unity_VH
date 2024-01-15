using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("PlayerDeath");
            ShowDeathScreen();
        }
    }
    
    private void ShowDeathScreen()
    {
        Time.timeScale = 0f;
        //TODO death screen
    }
}

using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject deathScreen;

    private void Update()
    {
        if (PlayerState.Instance.IsPlayerDead)
        {
            ShowDeathScreen();
        }
    }

    private void ShowDeathScreen()
    {
        Time.timeScale = 0f;
        deathScreen.SetActive(true);
    }
}
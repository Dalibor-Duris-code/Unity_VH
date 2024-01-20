using UnityEngine;

public class PlayerState : MonoBehaviour
{
    // Singleton instance
    public static PlayerState Instance { get; private set; }

    public bool IsPlayerDead { get; private set; }

    private void Awake()
    {
        // Ensure that there's only one instance of this object in the game
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Makes this object persistent across scenes
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetPlayerDeathState(bool isDead)
    {
        IsPlayerDead = isDead;
    }

    // Reset death state, call this when you restart the level or when necessary
    public void ResetDeathState()
    {
        IsPlayerDead = false;
    }
}
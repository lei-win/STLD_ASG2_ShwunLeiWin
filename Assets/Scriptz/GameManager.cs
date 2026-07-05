using UnityEngine;

public class GameManager : MonoBehaviour
{
    // This creates a global reference so other scripts can talk to it easily
    public static GameManager instance;

    [Header("Player Inventory")]
    public int crystals = 0;
    public int metalScraps = 0;
    public bool hasSpecialOrb = false;

    private void Awake()
    {
        // Sets up the global connection when the game starts
        if (instance == null)
        {
            instance = this;
        }
    }
}
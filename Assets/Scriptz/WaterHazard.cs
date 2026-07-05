using UnityEngine;
using UnityEngine.SceneManagement; // Needed to restart the level

public class WaterHazard : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the player hit the water
        if (other.CompareTag("Player"))
        {
            Debug.Log("PLAYER TOUCHED WATER! Restarting level...");
            
            // This reloads the current scene, essentially "respawning" the player
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
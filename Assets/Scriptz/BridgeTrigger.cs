using UnityEngine;

/// <summary>
/// Author: Student
/// Description: Manages the custom dynamic bridge collapsing event using Unity's physics trigger volume system.
/// </summary>
public class BridgeTrigger : MonoBehaviour
{
    /// <summary>The GameObject representing the fully intact, clean bridge.</summary>
    public GameObject intactBridge;

    /// <summary>The GameObject holding the broken/collapsed bridge fragments.</summary>
    public GameObject brokenBridge;

    /// <summary>Tracks whether the bridge has already collapsed to prevent re-triggering.</summary>
    private bool hasCollapsed = false;

    /// <summary>
    /// Unity built-in physics trigger detection. Swaps the bridge states on player entry.
    /// </summary>
    /// <param name="other">The collider component of the object entering the trigger zone.</param>
    private void OnTriggerEnter(Collider other)
    {
        // Prints a message to the console the absolute second ANYTHING touches the trigger zone
        Debug.Log("SOMETHING TOUCHED THE TRIGGER! Object name: " + other.gameObject.name);

        // Validates if the object has the 'Player' tag and hasn't triggered yet
        if (other.CompareTag("Player") && !hasCollapsed)
        {
            hasCollapsed = true;

            // Instantly swap the visible states of the bridge objects
            if (intactBridge != null) intactBridge.SetActive(false);
            if (brokenBridge != null) brokenBridge.SetActive(true);
            
            Debug.Log("SUCCESS: The bridge has collapsed! Path blocked.");
        }
    }
}
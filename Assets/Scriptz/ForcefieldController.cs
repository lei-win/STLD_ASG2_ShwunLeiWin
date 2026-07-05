using UnityEngine;

public class ForcefieldController : MonoBehaviour
{
    private bool fieldDestroyed = false;

    void Update()
    {
        // Check the game manager to see if the player picked up the orb
        if (GameManager.instance.hasSpecialOrb && !fieldDestroyed)
        {
            fieldDestroyed = true;
            
            // This makes the giant sheet disappear completely!
            gameObject.SetActive(false); 
            
            Debug.Log("Orb detected! Forcefield deactivated.");
        }
    }
}
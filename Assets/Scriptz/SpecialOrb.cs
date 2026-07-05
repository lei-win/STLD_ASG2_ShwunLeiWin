using UnityEngine;

// Inherits from Collectible!
public class SpecialOrb : Collectible 
{
    public override void OnCollect()
    {
        // Change the bool in the Game Manager to true!
        GameManager.instance.hasSpecialOrb = true;
        
        Debug.Log("Got the Special Orb! The base door can now be unlocked.");
        
        // Destroy the object
        base.OnCollect(); 
    }
}
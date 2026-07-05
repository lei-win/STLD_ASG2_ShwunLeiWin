using UnityEngine;

// Inherits from Collectible!
public class MetalScrap : Collectible 
{
    public override void OnCollect()
    {
        // Add 1 to the scrap count in our Game Manager
        GameManager.instance.metalScraps += 1;
        
        Debug.Log("Got a metal scrap! Total Scraps: " + GameManager.instance.metalScraps);
        
        // Destroy the object
        base.OnCollect(); 
    }
}

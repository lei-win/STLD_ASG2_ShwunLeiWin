using UnityEngine;

public class EnergyCrystal : Collectible
{
    public override void OnCollect()
    {
        // 1. Tell the Game Manager to add 1 to our crystal count
        GameManager.instance.crystals += 1;
        
        // 2. Print it to the console so we can see it working
        Debug.Log("Got a crystal! Total Crystals: " + GameManager.instance.crystals);
        
        // 3. Destroy the object (runs the code from the Master Blueprint)
        base.OnCollect();
    }
}
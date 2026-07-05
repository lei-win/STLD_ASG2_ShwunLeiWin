using UnityEngine;

// By changing MonoBehaviour to Collectible, this script inherits ALL the trigger code!
public class EnergyCrystal : Collectible
{
    // The override keyword lets us add specific crystal logic before it gets destroyed
    public override void OnCollect()
    {
        Debug.Log("SUCCESS: Picked up a crystal! +50 Points.");
        
        // base.OnCollect() tells Unity to run the destruction code from the Master Blueprint
        base.OnCollect();
    }
}
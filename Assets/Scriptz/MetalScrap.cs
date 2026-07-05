using UnityEngine;

public class MetalScrap : Collectible
{
    public override void OnCollect()
    {
        // 1. Add 1 to our metal scraps count
        GameManager.instance.metalScraps++;
        Debug.Log("Collected a metal scrap! Total scraps: " + GameManager.instance.metalScraps);
        
        // 2. Check if this was the final piece
        if (GameManager.instance.metalScraps >= 3)
        {
            WinGame();
        }

        // 3. Play destruction/collect effects from the base class
        base.OnCollect(); 
    }

    private void WinGame()
    {
        Debug.Log("YOU WIN! Collected all 3 metal scraps. Game Over!");
        
        // Freezes the game simulation completely
        Time.timeScale = 0f; 

        // TODO: This is where we will activate your "Victory/Credits" UI screen next!
    }
}
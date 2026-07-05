using UnityEngine;
using TMPro; // Needed for TextMeshPro

public class HUDManager : MonoBehaviour
{
    public TextMeshProUGUI hudText; // Drag your HUDText object here

    void Update()
    {
        // 1. Check the Orb state string
        string orbStatus = GameManager.instance.hasSpecialOrb ? "Found" : "Missing";

        // 2. Build the full inventory string text dynamically
        hudText.text = "Crystals: " + GameManager.instance.crystals + " / 3\n" +
                       "Etharno Orb: " + orbStatus + "\n" +
                       "Metal Scraps: " + GameManager.instance.metalScraps + " / 3";
    }
}
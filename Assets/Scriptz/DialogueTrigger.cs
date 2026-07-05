using UnityEngine;
using TMPro;

public class DialogueTrigger : MonoBehaviour
{
    public GameObject dialoguePanel; 
    public TextMeshProUGUI textMeshText; 
    
    [TextArea(3, 10)] 
    public string message = "Greetings, fleshy traveler! You want to rebuild your ship? The metal scraps you need are just across the river. Small problem: our bridge shattered into pieces! If you can find 3 Red Mana Crystals, their energy will fuse the bridge back together. Oh, and that giant glowing barrier blocking the base? It won't budge unless you bring your Etharno Orb from your rocket to overpower its energy grid! Go, hurry!";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (textMeshText != null)
            {
                textMeshText.text = message;
            }

            dialoguePanel.SetActive(true); 

            // 🔊 NEW: Grab the audio source on this alien and play it!
            AudioSource audio = GetComponent<AudioSource>();
            if (audio != null)
            {
                audio.Play();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            dialoguePanel.SetActive(false); 

            // Optional: Turn off the audio if the player walks away mid-sentence
            AudioSource audio = GetComponent<AudioSource>();
            if (audio != null)
            {
                audio.Stop();
            }
        }
    }
}
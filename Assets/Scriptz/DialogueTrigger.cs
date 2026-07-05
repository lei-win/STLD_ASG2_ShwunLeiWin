using UnityEngine;
using UnityEngine.UI; // Needed to control UI elements

public class DialogueTrigger : MonoBehaviour
{
    public GameObject dialoguePanel; // Drag your Text object here
    public string message = "Hello Human! Go find those crystals!";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            dialoguePanel.GetComponent<Text>().text = message;
            dialoguePanel.SetActive(true); // Show the text
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            dialoguePanel.SetActive(false); // Hide the text when you walk away
        }
    }
}
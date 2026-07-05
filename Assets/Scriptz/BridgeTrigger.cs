using UnityEngine;

public class BridgeTrigger : MonoBehaviour
{
    public GameObject intactBridge; 
    public GameObject brokenBridge; 
    private bool isRepaired = false; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && GameManager.instance.crystals >= 3 && !isRepaired)
        {
            isRepaired = true;

            // 1. Get the Audio Source attached to this trigger zone and play it
            AudioSource audio = GetComponent<AudioSource>();
            if (audio != null)
            {
                audio.Play();
            }

            // 2. Swap the bridge parts
            brokenBridge.SetActive(false); 
            intactBridge.SetActive(true);  
            
            Debug.Log("Bridge Rebuilt!!");
        }
    }
}
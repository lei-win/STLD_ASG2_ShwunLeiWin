using UnityEngine;

public class Collectible : MonoBehaviour
{
    [Header("Audio Settings")]
    public AudioClip collectSound; // This creates a slot in the Inspector for your sound file!

    public virtual void OnCollect()
    {
        // 1. Check if a sound is plugged in, then play it!
        // PlayClipAtPoint creates a temporary audio player so the sound doesn't get destroyed with the crystal.
        if (collectSound != null)
        {
            AudioSource.PlayClipAtPoint(collectSound, transform.position);
        }

        // 2. Destroy the 3D model from the scene
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OnCollect();
        }
    }
}
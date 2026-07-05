using UnityEngine;

public class Collectible : MonoBehaviour
{
    /// <summary>
    /// The virtual keyword means child scripts are allowed to override or add to this action!
    /// </summary>
    public virtual void OnCollect()
    {
        // This will destroy the 3D model from the scene when picked up
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        // If the player touches this object, trigger the OnCollect method
        if (other.CompareTag("Player"))
        {
            OnCollect();
        }
    }
}
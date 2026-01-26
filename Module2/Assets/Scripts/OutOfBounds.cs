using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class OutOfBounds : MonoBehaviour
{
    [Header("Reset")]
    [SerializeField] private Transform spawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        Rigidbody rb = other.attachedRigidbody;
        if (rb == null) return;

        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        other.transform.position = spawnPoint.position;
        other.transform.rotation = spawnPoint.rotation;
    }
}

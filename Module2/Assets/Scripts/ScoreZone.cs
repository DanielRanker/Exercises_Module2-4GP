using UnityEngine;
using TMPro;

public class ScoreZone : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] private TextMeshProUGUI scoreText;

    [Header("Scoring")]
    [SerializeField] private int pointsParBut = 1;

    [Header("Reset")]
    [SerializeField] private Transform spawnPoint;

    private int score = 0;

    private void Start()
    {
        RefreshUI();
    }

        private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        Rigidbody rb = other.attachedRigidbody;
        if (rb == null) return;

        // Add points
        score += pointsParBut;
        RefreshUI();

        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        other.transform.position = spawnPoint.position;
        other.transform.rotation = spawnPoint.rotation;
    }

    private void RefreshUI()
    {
        if (scoreText != null)
            scoreText.text = $"Score: {score}";
    }
}

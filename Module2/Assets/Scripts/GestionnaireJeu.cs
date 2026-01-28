using TMPro;
using UnityEngine;

public class GestionnaireJeu : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private ZoneArrivee zoneArrivee;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private Rigidbody balle;

    [Header("Score")]
    [SerializeField] private int pointsParBut = 1;
    
    private int score = 0;

    void Start()
    {
        zoneArrivee.OnBalleArrivee += GererArriveeBalle;
         
        RefreshUI();
    }

    private void GererArriveeBalle()
    {
        score += pointsParBut;
        RefreshUI();

        balle.linearVelocity = Vector3.zero;
        balle.angularVelocity = Vector3.zero;
        balle.transform.position = spawnPoint.position;
    }

    private void RefreshUI()
    {
               scoreText.text = $"Score : {score}";
    }
}

using System;
using UnityEngine;

public class ZoneArrivee : MonoBehaviour
{
    public event Action OnBalleArrivee;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        OnBalleArrivee?.Invoke();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

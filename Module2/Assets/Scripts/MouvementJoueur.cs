using UnityEngine;
using UnityEngine.InputSystem;

public class MouvementJoueur : MonoBehaviour
{
    private InputAction _move;
    private Rigidbody _rigidbody;

    [SerializeField]
    private float niveauForce = 10f;
    void Start()
    {
        _move = InputSystem.actions.FindAction("Move");
        _move.Enable();

        _rigidbody = GetComponent<Rigidbody>();
    }

    
    void FixedUpdate()
    {
        Vector2 mouvement = _move.ReadValue<Vector2>();
        Vector3 force = new Vector3(mouvement.x, 0f, mouvement.y) * niveauForce;

        _rigidbody.AddForce(force, ForceMode.Acceleration);
    }
}

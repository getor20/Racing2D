using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private Rigidbody2D rd2D;
    private Vector2 vector;

    [Space]
    [SerializeField]
    private float verticalSpeed = 5f;
    [Space]
    [SerializeField]
    private float horizontalSpeed = 2f;

    private void Awake()
    {
        rd2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rd2D.velocity = new Vector2(vector.x * horizontalSpeed, vector.y * verticalSpeed);
    }

    public void Move(InputAction.CallbackContext context)
    {
        vector = context.ReadValue<Vector2>();
    }
}

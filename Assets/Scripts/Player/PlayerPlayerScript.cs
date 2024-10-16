using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private Rigidbody2D rigidbody;

    private Vector2 vector2 = Vector2.zero;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();   
    }

    public void OnMove(InputAction.CallbackContext context)
    {

    }
}

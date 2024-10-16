using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private Vector2 vector2 = Vector2.zero;

    private void Awake()
    {
    }

    private void Update()
    {
        Debug.Log(vector2);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        vector2 = context.ReadValue<Vector2>();
    }
}

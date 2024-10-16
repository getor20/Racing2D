using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;

    private float speed = 0f;

    private Vector2 vector2 = Vector2.zero;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Debug.Log(speed);
    }

    private void FixedUpdate()
    {
        rigidbody2D.velocity = new Vector2(vector2.x * speed, vector2.y * speed);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        vector2 = context.ReadValue<Vector2>();

        if (context.started)
        {
            while (true)
            {
                speed += 10f;
            }        
        }
        else if (context.canceled)
        {
            while (true)
            {
                speed -= 10f;
            }
        }
    }
}

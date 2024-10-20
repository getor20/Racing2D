using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private Rigidbody2D rd2D;
    private Vector2 vector;

    [Space]
    [SerializeField]
    public float verticalSpeed = -1f;
    [Space]
    [SerializeField]
    private float horizontalSpeed = 2f;
    [SerializeField]
    private UI ui;

    private void Awake()
    {
        rd2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rd2D.velocity = new Vector2(vector.x * horizontalSpeed, 0);
        transform.Translate(Vector2.up * verticalSpeed * Time.deltaTime);
    }

    public void Move(InputAction.CallbackContext context)
    {
        vector = context.ReadValue<Vector2>();
    }

    public void verticalSpeedPlus()
    {
        verticalSpeed += 1;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        if (collision.name == "NPS(Clone)")
        {
            ui.GameOver();
        }
    }
}

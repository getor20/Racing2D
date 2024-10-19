using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private Rigidbody2D rd2D;
    private Vector2 vector;
    private Transform tr;

    [Space]
    [SerializeField]
    private float verticalSpeed = 0f;
    [Space]
    [SerializeField]
    private float horizontalSpeed = 3f;

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

    void Update()
    {
        Debug.Log("Пройденное КМ: " + transform.position.y);
    }
}

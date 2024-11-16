using Assets.Scripts.Select_Car;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private Rigidbody2D rd2D => GetComponent<Rigidbody2D>();
    private Vector2 vector;

    [Space]
    [SerializeField]
    public float verticalSpeed = 1f;
    [Space]
    [SerializeField]
    private float horizontalSpeed = 2f;
    [Space]
    [SerializeField]
    private Sprite[] sprites;
    private SpriteRenderer spriteRenderer => GetComponent<SpriteRenderer>();
    [SerializeField]
    private UI ui;

    private void FixedUpdate()
    {
        rd2D.velocity = new Vector2(vector.x * horizontalSpeed, 0);
        transform.Translate(Vector2.up * verticalSpeed * Time.deltaTime);
        SpriteCar();
    }

    public void Move(InputAction.CallbackContext context)
    {
        vector = context.ReadValue<Vector2>();
    }

    private void SpriteCar()
    {
        if (PlayerPrefs.GetInt(CarSpriteStrings.CarSprite) == 1)
        {
            spriteRenderer.sprite = sprites[0];
        }
        if (PlayerPrefs.GetInt(CarSpriteStrings.CarSprite) == 2)
        {
            spriteRenderer.sprite = sprites[1];
        }
        if (PlayerPrefs.GetInt(CarSpriteStrings.CarSprite) == 3)
        {
            spriteRenderer.sprite = sprites[2];
        }
        if (PlayerPrefs.GetInt(CarSpriteStrings.CarSprite) == 4)
        {
            spriteRenderer.sprite = sprites[3];
        }
    }

    public void SpeedPlus()
    {
        verticalSpeed += 1;
        horizontalSpeed += 1;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "NPS(Clone)")
        {
            ui.GameOver();
        }
    }
}

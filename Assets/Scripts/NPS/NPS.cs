using UnityEngine;

public class NPS : MonoBehaviour
{
    [Space]
    [SerializeField]
    private float speed = 1;    
    private Transform Transform;
    [Space]
    [SerializeField]
    private Sprite[] sprites;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }

    private void Start()
    {
        int randomSprites = Random.Range(0, sprites.Length);
        spriteRenderer.sprite = sprites[randomSprites];
    }
}

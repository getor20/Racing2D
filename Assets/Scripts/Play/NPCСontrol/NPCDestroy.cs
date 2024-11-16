using UnityEngine;

public class NPCDestroy : MonoBehaviour
{
    [SerializeField]
    private Player player;
    [SerializeField]
    private int followingDistance = 7;

    private void Update()
    {
        transform.position = new Vector2(transform.position.x, player.transform.position.y - followingDistance);    
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}

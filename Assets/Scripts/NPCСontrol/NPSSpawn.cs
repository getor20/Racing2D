using UnityEngine;

public class NPCNPSSpawn : MonoBehaviour
{
    [SerializeField]
    private Player player;
    [SerializeField]
    private int followingDistance = 6;

    private void Update()
    {
        transform.position = new Vector2(transform.position.x, player.transform.position.y + followingDistance);

    }
}

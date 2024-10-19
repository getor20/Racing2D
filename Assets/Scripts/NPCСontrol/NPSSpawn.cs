using System.Collections;
using UnityEngine;

public class NPCNPSSpawn : MonoBehaviour
{
    [SerializeField]
    private Player player;
    [Space]
    [SerializeField]
    private GameObject[] nps;
    [Space]
    [SerializeField]
    private int followingDistance = 6;
    private float[] positions = {0.75f, -0.75f};
    private Transform transformi;

    private void Update()
    {
        transformi.position = new Vector2(transform.position.x, player.transform.position.y + followingDistance);

    }

    private void Awake()
    {
        transformi = GetComponent<Transform>();
    }

    private void Start()
    {
        StartCoroutine(spawn());
    }
    IEnumerator spawn()
    {
        while (true)
        {
            Instantiate(nps[Random.Range(0, nps.Length)], new Vector3(positions[Random.Range(0, 2)], transformi.position.y, 0), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
        }
    }
}

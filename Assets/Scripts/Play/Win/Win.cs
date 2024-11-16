using UnityEngine;

public class Win : MonoBehaviour
{
    [SerializeField]
    private UI uI;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        uI.Win();
    }
}

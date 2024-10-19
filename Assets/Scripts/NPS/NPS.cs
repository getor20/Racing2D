using UnityEngine;

public class NPS : MonoBehaviour
{
    [Space]
    [SerializeField]
    private float speed = 1;    
    private Transform Transform;

    private void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);

    }

    
}

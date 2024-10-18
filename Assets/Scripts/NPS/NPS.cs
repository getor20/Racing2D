using UnityEngine;

public class NPS : MonoBehaviour
{
    [Space]
    [SerializeField]
    private float speed = 3;

    private void FixedUpdate()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
}

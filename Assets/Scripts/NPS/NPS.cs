using UnityEngine;

public class NPS : MonoBehaviour
{
    [Space]
    [SerializeField]
    private float speed = 1;    
    private Transform Transform;
    private Vector2 vector2 = Vector2.zero;
    /*private BoxCollider2D TouchingBoxCollider;*/

    private void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        /*TouchingBoxCollider = GetComponent<BoxCollider2D>();
        Debug.Log(TouchingBoxCollider.name);*/

    }

    public void Destroy()
    {
        Destroy(gameObject);
        Instantiate(gameObject, new Vector3(-0.75f, 4.15f, 0), Quaternion.identity);

    }
}

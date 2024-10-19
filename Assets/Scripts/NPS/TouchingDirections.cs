using UnityEngine;

public class TouchingDirections : MonoBehaviour
{
    private BoxCollider2D TouchingBoxCollider;
    public bool OnGround { get; private set; }

    private NPS nps;

    private RaycastHit2D[] hits = new RaycastHit2D[5];
    private float graundDistans = 0.05f;

    private void Awake()
    {

        TouchingBoxCollider = GetComponent<BoxCollider2D>();
        nps = GetComponent<NPS>();
    }

    private void FixedUpdate()
    {
        CheckGround();
        if (OnGround)
        {
            nps.Destroy();
            Debug.Log(TouchingBoxCollider.name);
        }
    }

    private void CheckGround()
    {
        OnGround = TouchingBoxCollider.Cast(Vector2.down, hits, graundDistans) > 0;

    }

}
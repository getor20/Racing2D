using UnityEngine;

public class Player : MonoBehaviour
{
    [Space]
    [SerializeField]
    private Transform Transform;                                                                                                    
    private Vector3 vector;
    private int speed;


    private void Update()
    {
        transform.position += vector;

        if (Input.GetKey(KeyCode.W))
        {
            vector += (Transform.up * Time.deltaTime) * 0.03f;
        }
        else
        {
            Braking();
        }

        if (Input.GetKey(KeyCode.S))
        {
            vector -= (Transform.up * Time.deltaTime) * 0.02f;
        }
        else
        {
            Braking();
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Braking();
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, 0.35f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -0.35f);
        }
    }

    private void Braking()
    {
        vector = Vector3.Lerp(vector, Vector3.zero, Time.deltaTime);
    }
    
}

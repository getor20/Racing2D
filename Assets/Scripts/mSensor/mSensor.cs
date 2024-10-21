using UnityEngine;

public class mSensor : MonoBehaviour
{
    [SerializeField]
    private Player player;
        
    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.SpeedPlus();
    }
}

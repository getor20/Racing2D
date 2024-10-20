using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField]
    private GameObject GameOvers;
    [SerializeField]
    private GameObject Wins;
    public void GameOver()
    {
        GameOvers.SetActive(true);
        Time.timeScale = 0;
    }

    public void Win()
    {
        Wins.SetActive(true);
        Time.timeScale = 0;
    }
}

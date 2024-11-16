using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField]
    private int SceneNumber;
    [Space]
    [SerializeField]
    private GameObject Plays;
    [SerializeField]
    private GameObject Exits;

    private void Start()
    {
        Plays.SetActive(true);
        Exits.SetActive(true);
    }

    public void Play()
    {
        SceneManager.LoadScene(SceneNumber);
    }

    public void Back()
    {
        Plays.SetActive(true);
        Exits.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Выход");
    }
}

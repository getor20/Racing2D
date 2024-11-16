using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    [SerializeField]
    private GameObject GameOvers;
    [SerializeField]
    private GameObject Wins;
    [SerializeField]
    private GameObject PanelMenu;
    [SerializeField]
    private Player Player;
    [SerializeField]
    private GameObject DistanceTraveledSetActive;
    [SerializeField]
    private TMP_Text DistanceTraveled;

    private bool on_offESC = false;
    private bool GameOversWins = true;
    private bool spriteSelection;
    [SerializeField]
    private int SceneNumber;

    private void Start()
    {

        PanelMenu.SetActive(false);
        Time.timeScale = 1;
    }

    private void Update()
    {
        DistanceTraveled.text = $"Distance Traveled: {(int)Player.transform.position.y}";
    }

    public void GameOver()
    {
        GameOvers.SetActive(true);
        Time.timeScale = 0;
        GameOversWins = false;
        DistanceTraveledSetActive.SetActive(false);
    }

    public void Win()
    {
        Wins.SetActive(true);
        Time.timeScale = 0;
        GameOversWins = false;
        DistanceTraveledSetActive.SetActive(false);
    }

    public void ESC()
    {
        if (!on_offESC)
        {
            PanelMenu.SetActive(true);
            on_offESC = true;
            Time.timeScale = 0;
        }
        else if (on_offESC)
        {
            PanelMenu.SetActive(false);
            on_offESC = false;
            if (GameOversWins)
            {
                Time.timeScale = 1;
            }
            else if (!GameOversWins)
            {
                Time.timeScale = 0;
            }
        }
        
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void SelectCar()
    {
        SceneNumber = 2;
        SceneManager.LoadScene(SceneNumber);
    }

    public void Menu()
    {
        SceneNumber = 1;
        SceneManager.LoadScene(SceneNumber);
    }
}

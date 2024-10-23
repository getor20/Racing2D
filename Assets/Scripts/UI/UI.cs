using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    [SerializeField]
    private GameObject GameOvers;
    [SerializeField]
    private GameObject Wins;
    [SerializeField]
    private GameObject Selecting—ar;
    [SerializeField]
    private GameObject HAVE_NOT_CHOSEN;
    [SerializeField]
    private Player Player;
    [SerializeField]
    private Sprite[] sprites;
    private bool spriteSelection;
    [SerializeField]
    private int SceneNumber;

    private void Start()
    {
        Time.timeScale = 0;
        GameOvers.SetActive(false);
        Wins.SetActive(false);
        HAVE_NOT_CHOSEN.SetActive(false);
    }

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

    public void Play()
    {
        if (spriteSelection == true)
        {
            Selecting—ar.SetActive(false);
            Time.timeScale = 1;
        }
        else if (spriteSelection == false)
        {
            Time.timeScale = 0;
            HAVE_NOT_CHOSEN.SetActive(true);
        }
    }

    public void SpriteSelection()
    {
        if (Player.spriteRenderer.sprite != sprites[0])
        {
            spriteSelection = false;
        }
        else if(Player.spriteRenderer.sprite != sprites[1])
        {
            spriteSelection = false;
        }
        else if (Player.spriteRenderer.sprite != sprites[2])
        {
            spriteSelection = false;
        }
        else if (Player.spriteRenderer.sprite != sprites[3])
        {
            spriteSelection = false;
        }
    }

    public void Car1()
    {
        Player.spriteRenderer.sprite = sprites[0];
        spriteSelection = true;
    }
    public void Car2()
    {
        Player.spriteRenderer.sprite = sprites[1];
        spriteSelection = true;
    }
    public void Car3()
    {
        Player.spriteRenderer.sprite = sprites[2];
        spriteSelection = true;
    }
    public void Car4()
    {
        Player.spriteRenderer.sprite = sprites[3];
        spriteSelection = true;
    }

    public void ESC()
    {
        SceneManager.LoadScene(SceneNumber);
    }
}

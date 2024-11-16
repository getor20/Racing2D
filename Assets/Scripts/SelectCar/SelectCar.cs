using Assets.Scripts.Select_Car;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectCar : MonoBehaviour
{
    [SerializeField]
    private int SceneNumber;
    [SerializeField]
    private GameObject HAVE_NOT_CHOSEN;
    [SerializeField]
    private Sprite[] sprite;
    [SerializeField]
    private SpriteRenderer spriteRenderer;
    private bool Plays;

    private void Start()
    {
        HAVE_NOT_CHOSEN.SetActive(false);
    }

    public void Play()
    {
        if (Plays)
        {
            SceneManager.LoadScene(SceneNumber);
        }
        else if (!Plays)
        {
            HAVE_NOT_CHOSEN.SetActive(true);
        }
    }

    public void Back()
    {
        SceneNumber = 1;
        SceneManager.LoadScene(SceneNumber);
    }

    public void Car1()
    {
        Plays = true;
        PlayerPrefs.SetInt(CarSpriteStrings.CarSprite, 1);
        HAVE_NOT_CHOSEN.SetActive(false);
        spriteRenderer.sprite = sprite[0];
    }
    public void Car2()
    {
        Plays = true;
        PlayerPrefs.SetInt(CarSpriteStrings.CarSprite, 2);
        HAVE_NOT_CHOSEN.SetActive(false);
        spriteRenderer.sprite = sprite[1];
    }
    public void Car3()
    {
        Plays = true;
        PlayerPrefs.SetInt(CarSpriteStrings.CarSprite, 3);
        HAVE_NOT_CHOSEN.SetActive(false);
        spriteRenderer.sprite = sprite[2];
    }
    public void Car4()
    {
        Plays = true;
        PlayerPrefs.SetInt(CarSpriteStrings.CarSprite, 4);
        HAVE_NOT_CHOSEN.SetActive(false);
        spriteRenderer.sprite = sprite[3];
    }
}

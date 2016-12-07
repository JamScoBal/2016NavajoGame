using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverMenu : MonoBehaviour {

    public Text Scoretext;
    public AudioSource button;

    void Start()
    {
        Scoretext.text = StarCounter.starCount.ToString();
        button = GetComponent<AudioSource>();
    }

    public void Menu()
    {
        Timer.myTimer = 180;
        Lives.PlayerLives = 4;
        StarCounter.starCount = 0;
        Application.LoadLevel(0);
        button.Play();
    }

    public void Replay()
    {
        Timer.myTimer = 180;
        Lives.PlayerLives = 4;
        StarCounter.starCount = 0;
        Application.LoadLevel(1);
        button.Play();
    }

    public void EndLevel()
    {
        Application.Quit();
        button.Play();
    }
}

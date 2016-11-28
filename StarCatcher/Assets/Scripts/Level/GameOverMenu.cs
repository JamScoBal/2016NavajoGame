using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverMenu : MonoBehaviour {

    public Text Scoretext;

    void Start()
    {
        Scoretext.text = StarCounter.starCount.ToString();
    }

    public void Menu()
    {
        Timer.myTimer = 180;
        Lives.PlayerLives = 4;
        StarCounter.starCount = 0;
        Application.LoadLevel(0);
    }

    public void Replay()
    {
        Timer.myTimer = 180;
        Lives.PlayerLives = 4;
        StarCounter.starCount = 0;
        Application.LoadLevel(1);
    }

    public void EndLevel()
    {
        Application.Quit();
    }
}

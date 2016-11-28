using UnityEngine;
using System.Collections;

public class GameOverMenu : MonoBehaviour {

    public void Menu()
    {
        Timer.myTimer = 180;
        Lives.PlayerLives = 4;
        Application.LoadLevel(0);
    }

    public void Replay()
    {
        Timer.myTimer = 180;
        Lives.PlayerLives = 4;
        Application.LoadLevel(1);
    }

    public void EndLevel()
    {
        Application.Quit();
    }
}

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HUDScript : MonoBehaviour {

    public Button BackButton;
    public AudioSource button;

    void Start ()
    {
        BackButton = BackButton.GetComponent<Button>();
        button = GetComponent<AudioSource>();
    }

    public void BackLevel()
    {
        Application.LoadLevel(0);
        button.Play();
    }
}

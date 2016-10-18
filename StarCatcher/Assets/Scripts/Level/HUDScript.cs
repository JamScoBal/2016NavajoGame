using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HUDScript : MonoBehaviour {

    public Button BackButton;

    void Start ()
    {
        BackButton = BackButton.GetComponent<Button>();
    }

    public void BackLevel()
    {
        Application.LoadLevel(0);
    }
}

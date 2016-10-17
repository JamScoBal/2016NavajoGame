using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuScript : MonoBehaviour {

    public Canvas StartMenu;
    public Canvas InstructionMenu;
    public Button BackButton;
    public Button StartButton;
    public Button InstructionButton;
    public Button ExitButton;

    // Use this for initialization
    void Start () {
        StartMenu = StartMenu.GetComponent<Canvas>();
        InstructionMenu = InstructionMenu.GetComponent<Canvas>();
        BackButton = BackButton.GetComponent<Button>();
        ExitButton = ExitButton.GetComponent<Button>();
        StartButton = StartButton.GetComponent<Button>();
        InstructionButton = InstructionButton.GetComponent<Button>();
        InstructionMenu.enabled = false;
	}
	
    public void StartPress()
    {
        StartButton.enabled = false;
        ExitButton.enabled = false;
        InstructionButton.enabled = false;
    }

	public void InstructionPress()
    {
        InstructionMenu.enabled = true;
        StartMenu.enabled = false;
    }

    public void BackPress()
    {
        InstructionMenu.enabled = false;
        StartMenu.enabled = true;
    }

    public void StartLevel()
    {
        Application.LoadLevel(1);
    }

    public void EndLevel()
    {
        Application.Quit();
    }
}

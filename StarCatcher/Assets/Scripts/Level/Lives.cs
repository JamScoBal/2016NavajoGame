using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Lives : MonoBehaviour {

    public static int PlayerLives = 4;

	// Use this for initialization
	void Start () {
        PlayerLives--;
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Text>().text = PlayerLives.ToString();

        if(PlayerLives < 0)
        {
            Application.LoadLevel(2);
        }
	}
}

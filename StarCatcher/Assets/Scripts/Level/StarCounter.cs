using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StarCounter : MonoBehaviour {

    public int starCount;
    public Text starText;
	
	// Update is called once per frame
	void Update () {
        starText.text = ("X " + starCount);
	}

    public void AddPoints(int points)
    {
        starCount += points;
    }
}

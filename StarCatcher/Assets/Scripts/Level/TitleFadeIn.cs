using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TitleFadeIn : MonoBehaviour {

    public CanvasGroup Title;

    IEnumerator Start()
    {
        Title.alpha = 0;

        while(Title.alpha < 1)
        {
            Title.alpha += Time.deltaTime / 8;
            yield return null;
        }
    }
}

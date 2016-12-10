using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SplashScreen : MonoBehaviour {

    public Image splashImage;

    IEnumerator Start()
    {
        splashImage.canvasRenderer.SetAlpha(1.0f);

        FadeOut();
        yield return new WaitForSeconds(5.0f);
    }

   void FadeOut()
    {
        splashImage.CrossFadeAlpha(0.0f, 5.0f, false);
    }
}

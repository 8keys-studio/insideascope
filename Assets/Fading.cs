using UnityEngine;
using System.Collections;

public class Fading : MonoBehaviour {

    public Texture2D fadeOutTexture;
    public float fadeSpeed = 0.8f;

    private int drawDepth = -1000;
    private float alpha = 1.0f;

    //private bool sceneStarting = true;
    private int fadeDir = -1;

    /*
    void Awake ()
    {
        guiTexture. = new Rect(0, 0, Screen.width, Screen.height);
    }

    void Update()
    {

    }

    void FadeToClear()
    {
        guiTexture.color = Color.Lerp(guiTexture.color
    }
    */

    void OnGui ()
    {
        Debug.Log("Fade: " + fadeSpeed);
        alpha += fadeDir * fadeSpeed * Time.deltaTime;
        alpha = Mathf.Clamp01(alpha);

        GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b);
        GUI.depth = drawDepth;
        GUI.DrawTexture ( new Rect (0,0, Screen.width, Screen.height), fadeOutTexture);
    }

    public float BeginFade (int direction)
    {
        Debug.Log("Begin Fade: " + fadeDir);
        fadeDir = direction;
        return (fadeSpeed);
    }

    void OnLevelWasLoaded (int level)
    {
        Debug.Log("Level Loaded: " + level);

        BeginFade(-1);
    }

}

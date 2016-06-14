using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextScript : MonoBehaviour {
    //publc variables
    public Text text;
    public static bool colorChange;
    public bool textChange;

    //private variables
    private enum LoopState {
        first, second, third
        };
    private Color targetColor;

	// Use this for initialization
	void Start () {
        targetColor = text.color;
        targetColor.a = 0f;
        text.color = targetColor;
	}
	
	// Update is called once per frame
	void Update () {
	    if (colorChange){
            showText();
        } else {
            hideText();
        }
    }

    void showText() {
        targetColor.a = 1f;
        text.color = targetColor;
        Debug.Log("Text Should appear!");
    }

    void hideText() {
        targetColor.a = 0f;
        text.color = targetColor;
        Debug.Log("Text should dissapear!");
    }
}

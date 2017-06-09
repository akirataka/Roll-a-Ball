using UnityEngine;
using UnityEngine.UI;

public class WinScore : MonoBehaviour {

    private int      score;
    private Text     winText;

    public ScoreScript scoreScript;

    private void Start ()
    {
        winText = GetComponent<Text> ();
        winText.text = "";
    }

    private void Update ()
    {
        if (scoreScript.score >= 12 ) {
            winText.text = "You Win!";
        }
    }

}

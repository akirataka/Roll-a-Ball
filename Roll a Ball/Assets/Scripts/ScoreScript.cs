using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

    public int      score;
    private Text     scoreText;
    
	private void Start () {
        scoreText = GetComponent<Text> ();
        SetScoreText ();
    }

    private void Update () {
        SetScoreText ();
	}

    private void SetScoreText ()
    {
        scoreText.text = "Score: " + score.ToString ();
    }

    public void IncrementScore ()
    {
        score += 1;
    }
}

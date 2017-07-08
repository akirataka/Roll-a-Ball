using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

    //-------------------------------------------------------------------------
    // Variables
    public  int      scoreNumber;
    private Text     scoreText;
    //-------------------------------------------------------------------------

    //-------------------------------------------------------------------------
    // Awake is used to references between Objects or Components
    private void Awake ()
    {
        scoreText = GetComponent<Text> ();
    }
    //-------------------------------------------------------------------------

    //-------------------------------------------------------------------------
    private void Update () {
        scoreText.text = "Score: " + scoreNumber.ToString ();
    }
    //-------------------------------------------------------------------------

    //-------------------------------------------------------------------------
    public void IncrementScore ()
    {
        scoreNumber += 1;
    }
    //-------------------------------------------------------------------------

}

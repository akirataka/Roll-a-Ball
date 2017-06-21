using UnityEngine;
using UnityEngine.UI;

public class WinScore : MonoBehaviour {

    //-------------------------------------------------------------------------
    // Variables
    private Text     winText;

    public int numPickUps;

    public ScoreScript scoreScript;
    //-------------------------------------------------------------------------

    //-------------------------------------------------------------------------
    // Awake is used to references between Objects or Components
    private void Awake ()
    {
        winText = GetComponent<Text> ();
        numPickUps = GameObject.FindGameObjectsWithTag ( "PickUp" ).Length;
    }
    //-------------------------------------------------------------------------

    //-------------------------------------------------------------------------
    private void Start ()
    {
        winText.text = "";
    }
    //-------------------------------------------------------------------------

    //-------------------------------------------------------------------------
    private void Update ()
    {
        if ( scoreScript.score >= numPickUps ) {
            winText.text = "You Win!";
        }
    }
    //-------------------------------------------------------------------------

}

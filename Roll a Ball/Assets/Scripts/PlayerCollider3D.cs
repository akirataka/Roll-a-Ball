using UnityEngine;

public class PlayerCollider3D : MonoBehaviour {

    //-------------------------------------------------------------------------
    // Varibles
    private ScoreScript scoreScript;
    //-------------------------------------------------------------------------

    //-------------------------------------------------------------------------
    private void Awake ()
    {
        scoreScript = FindObjectOfType<ScoreScript> ();
    }
    //-------------------------------------------------------------------------

    //-------------------------------------------------------------------------
    private void OnTriggerEnter ( Collider other )
	{
        if ( other.tag == "PickUp" ) {
            other.gameObject.SetActive ( false );
            scoreScript.IncrementScore();
        }
	}
    //-------------------------------------------------------------------------

}

using UnityEngine;

public class PlayerCollider3D : MonoBehaviour {

    //-------------------------------------------------------------------------
    // Variables
    private ScoreScript scoreScript;
    //-------------------------------------------------------------------------

    //-------------------------------------------------------------------------
    // Awake is used to references between Objects or Components
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

            if ( scoreScript )
            {
                scoreScript.IncrementScore ();
            }

        }
	}
    //-------------------------------------------------------------------------

}

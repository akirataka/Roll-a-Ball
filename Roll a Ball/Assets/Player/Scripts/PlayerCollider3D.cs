using UnityEngine;

public class PlayerCollider3D : MonoBehaviour {

    //-------------------------------------------------------------------------
    // Variables
    public ScoreScript scoreScript;
    //-------------------------------------------------------------------------

    //-------------------------------------------------------------------------
    private void OnTriggerEnter ( Collider other )
    {
        if ( other.tag == "PickUp" ) {

            other.gameObject.SetActive ( false );

            if ( scoreScript ) {
                scoreScript.IncrementScore ();
            }

        }
    }
    //-------------------------------------------------------------------------

}

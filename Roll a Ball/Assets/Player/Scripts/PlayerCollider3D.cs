using UnityEngine;

public class PlayerCollider3D : MonoBehaviour {

    //-------------------------------------------------------------------------
    // Variables
    public  ScoreScript     scoreScript;
    private string          targetTag = "PickUp";
    //-------------------------------------------------------------------------

    //-------------------------------------------------------------------------
    private void OnTriggerEnter ( Collider other )
    {
        if ( other.tag == targetTag ) {

            other.gameObject.SetActive ( false );

            if ( scoreScript ) {
                scoreScript.IncrementScore ();
            }

        }
    }
    //-------------------------------------------------------------------------

}

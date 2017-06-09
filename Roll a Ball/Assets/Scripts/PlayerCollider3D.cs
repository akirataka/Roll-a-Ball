using UnityEngine;

public class PlayerCollider3D : MonoBehaviour {

    public ScoreScript scoreScript;

    void OnTriggerEnter ( Collider other )
	{
        if ( other.tag == "PickUp" ) {
            other.gameObject.SetActive ( false );
            scoreScript.IncrementScore();
        }
	}
	
}

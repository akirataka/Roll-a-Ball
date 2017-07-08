using UnityEngine;

public class PlayerController3D : MonoBehaviour {

    //-------------------------------------------------------------------------
    // Variables
    public  float       speed;
    private Rigidbody   rigibody;
    //-------------------------------------------------------------------------

    //-------------------------------------------------------------------------
    // Awake is used to references between Objects or Components
    private void Awake ()
    {
        rigibody = GetComponent<Rigidbody> ();
    }
    //-------------------------------------------------------------------------

    //-------------------------------------------------------------------------
    // FixedUpdate is used to Objects Movement
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis( "Horizontal" );
        float moveVertical = Input.GetAxis( "Vertical" );

        Vector3 movement = new Vector3( moveHorizontal , 0 , moveVertical );

        rigibody.AddForce ( speed * movement );
    }
    //-------------------------------------------------------------------------

}
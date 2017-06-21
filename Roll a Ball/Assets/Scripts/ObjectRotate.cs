using UnityEngine;

public class ObjectRotate : MonoBehaviour {

    //-------------------------------------------------------------------------
    // Variables
    public Vector3 vectorAngular;
    //-------------------------------------------------------------------------

    //-------------------------------------------------------------------------
    // FixedUpdate is used to Objects Movement
    private void FixedUpdate ()
    {
        transform.Rotate ( vectorAngular * Time.deltaTime );
    }
    //-------------------------------------------------------------------------

}

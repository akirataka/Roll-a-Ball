using UnityEngine;

public class ObjectRotate : MonoBehaviour {

    //-------------------------------------------------------------------------
    // Variables
    public Vector3 vectorAngular;
    //-------------------------------------------------------------------------

    //-------------------------------------------------------------------------
    // FixedUpdate is used to Physics Objects Movement
    private void FixedUpdate ()
    {
        transform.Rotate ( Time.deltaTime * vectorAngular );
    }
    //-------------------------------------------------------------------------

}

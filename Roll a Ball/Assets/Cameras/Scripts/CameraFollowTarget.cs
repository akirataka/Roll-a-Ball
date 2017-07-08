using UnityEngine;

public class CameraFollowTarget : MonoBehaviour {

    //-------------------------------------------------------------------------
    // Variables
    public  Transform   target;
    private Vector3     offset;
    //-------------------------------------------------------------------------

    //-------------------------------------------------------------------------
    private void Start ()
    {
        offset = transform.position - target.position;
    }
    //-------------------------------------------------------------------------

    //-------------------------------------------------------------------------
    // LateUpdate is used for Camera Movement
    private void LateUpdate ()
    {
        transform.position = target.position + offset;
    }
    //-------------------------------------------------------------------------
    
}

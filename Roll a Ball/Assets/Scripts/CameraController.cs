using UnityEngine;

public class CameraController : MonoBehaviour {

    //-------------------------------------------------------------------------
    // Variables
    private Transform   player;
    private Vector3     cameraFixed;
    //-------------------------------------------------------------------------

    //-------------------------------------------------------------------------
    // Awake is used to references between Objects or Components
    private void Awake ()
    {
        player = GameObject.FindWithTag ( "Player" ).transform;
    }
    //-------------------------------------------------------------------------

    //-------------------------------------------------------------------------
    // Start is used to...
    private void Start ()
    {
        cameraFixed = transform.position - player.position;
    }
    //-------------------------------------------------------------------------

    //-------------------------------------------------------------------------
    // LateUpdate is used for Camera Movement
    private void LateUpdate ()
    {
        transform.position = player.position + cameraFixed;
    }
    //-------------------------------------------------------------------------
    
}

using UnityEngine;

public class CameraController : MonoBehaviour {

    //-------------------------------------------------------------------------
    // Varibles
    private Transform   player;
    private Vector3     cameraFixed;
    //-------------------------------------------------------------------------

    //-------------------------------------------------------------------------
    // Awake is used to references between Objects
    private void Awake ()
    {
        player = GameObject.FindWithTag ( "Player" ).transform;
    }
    //-------------------------------------------------------------------------

    //-------------------------------------------------------------------------
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

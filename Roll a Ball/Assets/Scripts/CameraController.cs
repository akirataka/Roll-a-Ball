using UnityEngine;

public class CameraController : MonoBehaviour {

    private Vector3 cameraFixed;

    public Transform player;
    
    private void Start ()
    {
        cameraFixed = transform.position - player.position;
    }

    private void LateUpdate ()
    {
        transform.position = player.position + cameraFixed;
    }

}

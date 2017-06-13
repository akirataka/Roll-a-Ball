using UnityEngine;

public class ObjectRotator : MonoBehaviour {

    public Vector3 vectorAngular;

    private void Update ()
    {
        transform.Rotate ( vectorAngular * Time.deltaTime );
    }

}

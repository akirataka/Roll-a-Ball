using UnityEngine;

public class ObjectRotator : MonoBehaviour {

    private Vector3 vectorAngular;
    
    private void Start ()
    {
        vectorAngular = new Vector3 ( 15 , 30 , 45 );
    }

    private void Update ()
    {
        transform.Rotate ( vectorAngular * Time.deltaTime );
    }

}

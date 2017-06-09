using UnityEngine;

public class PlayerController3D : MonoBehaviour {

    private float speed;
    private Rigidbody rb;
	
	private void Start()
	{
        speed = 10;
        rb = GetComponent<Rigidbody> ();
	}

	private void FixedUpdate()
	{
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3( moveHorizontal , 0 , moveVertical );

        rb.AddForce ( movement * speed );
	}

}
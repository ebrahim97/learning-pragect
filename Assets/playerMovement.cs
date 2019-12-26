using UnityEngine;

public class playerMovement : MonoBehaviour {
	public Rigidbody rb;
	public float forwardForce = 2000f;
	public float besideForce = 500f;
	void FixedUpdate () {

		rb.AddForce(0, 0, forwardForce * Time.deltaTime ,ForceMode.VelocityChange) ;

		if(Input.GetKey("d")){

			rb.AddForce(besideForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange ) ;

		}

		if(Input.GetKey("a")){

			rb.AddForce(-besideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange ) ;
		}
	}
}

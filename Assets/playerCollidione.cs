using UnityEngine;

public class playerCollidione : MonoBehaviour {
	public playerMovement movement;
	void OnCollisionEnter(Collision collisionInfo){

		if(collisionInfo.collider.tag == "obstacle"){

			movement.enabled = false;
		}
	}
}

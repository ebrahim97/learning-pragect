using UnityEngine;

public class playerCollidione : MonoBehaviour {
	public playerMovement movement;
	public gameControler gameControlerObgect;
	void OnCollisionEnter(Collision collisionInfo){

		if(collisionInfo.collider.tag == "obstacle"){

			movement.enabled = false;
			gameControlerObgect.endGame();
		}
	}
}

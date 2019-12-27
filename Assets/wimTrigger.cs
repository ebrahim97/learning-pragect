using UnityEngine;

public class wimTrigger : MonoBehaviour {

	public gameControler gameControlerObject;
	void OnTriggerEnter( ){
		gameControlerObject.winGame();
	}

}

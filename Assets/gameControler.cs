using UnityEngine;
using UnityEngine.SceneManagement;
public class gameControler : MonoBehaviour {
	bool gameHasEnded = false;
	public float restartTime = 2f;

	public GameObject winPanel;
	public void endGame(){
		if(gameHasEnded == false){

			Debug.Log("end game");
			gameHasEnded = true;
			Invoke("restart",restartTime);
		}
			
	}
	public void winGame(){

		winPanel.SetActive(true);
	}

	void restart(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);

	}
}

using UnityEngine;

public class followPlayer : MonoBehaviour {
	// Update is called once per frame
	public Transform playerTransform;
	public Vector3 offset;
	void Update () {
		transform.position = playerTransform.position + offset;
	}
}

using UnityEngine;
using System.Collections;

public class dogTrigger : MonoBehaviour {

	// Use this for initialization
	void onTriggerEnter2D(BoxCollider2D other) {
		dogMovement.dogCatch();
		Debug.Log("Hit!");
	}
}

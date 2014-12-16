using UnityEngine;
using System.Collections;

public class DuckDies : MonoBehaviour {
	public float duckNewGravity = 5f;
	//when clicked, enable rigid body gravity so duck falls to hit bottom collider

	void OnMouseDown () {

		rigidbody2D.gravityScale = duckNewGravity; 
		StaticVars.gameScore++;
		StaticVars.bullets--;

		}

	void OnTriggerEnter2D (Collider2D other) {
		Destroy (gameObject);
	
	}
	
	//when duck hits collider, destroy. so, top collider and bottom collider. it falls when clicked, then dies when hit bottom collider 
}

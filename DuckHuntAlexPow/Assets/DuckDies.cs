using UnityEngine;
using System.Collections;

public class DuckDies : MonoBehaviour {

	//when clicked, enable rigid body gravity so duck falls to hit bottom collider
	void OnMouseDown () {
		rigidbody2D.WakeUp(); 

		}

	void OnTriggerEnter () {
		Destroy (gameObject);

	}
	
	//when duck hits collider, destroy. so, top collider and bottom collider. it falls when clicked, then dies when hit bottom collider 
}

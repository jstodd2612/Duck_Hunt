using UnityEngine;
using System.Collections;

public class trigger : MonoBehaviour {
	
	public GameObject duck;

	// Use this for initialization
	void OnTriggerEnter2D(Collider2D whatever){
		Debug.Log ("Hit");
		shots.gunshots = 3;
		Destroy (duck);


		Instantiate (duck);

		killDuck.reviveDuck();
		
	}
}

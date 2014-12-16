using UnityEngine;
using System.Collections;

public class triggerFly : MonoBehaviour {

	public GameObject duck;

	void OnTriggerEnter2D(Collider2D whatever){
		Debug.Log ("Hit fly");
		shots.gunshots = 3;
		Destroy (duck);
		
	}
}

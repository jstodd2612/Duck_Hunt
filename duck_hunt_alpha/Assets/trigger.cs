using UnityEngine;
using System.Collections;

public class trigger : MonoBehaviour {
	
	public GameObject duck;
	private float startx = 0.1f;
	private float starty = 0.1f;

	// Use this for initialization
	void OnTriggerEnter2D(Collider2D whatever){
		Debug.Log ("Hit");
		shots.gunshots = 3;
		Destroy (duck);


		Instantiate (duck, new Vector3(startx, starty, 0), Quaternion.identity);

		killDuck.reviveDuck();
		
	}
}

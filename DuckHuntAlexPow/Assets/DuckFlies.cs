using UnityEngine;
using System.Collections;

public class DuckFlies : MonoBehaviour {

	public float speed = .05f;
	public bool direction = true;
	public float upFly = 0f;
	//gravity makes it go up
	
	void Start () {
		ResetDirection ();
	}
	
	void Update () {
		if (direction) {
			transform.position += new Vector3 (speed, upFly);
		} else {
			transform.position += new Vector3 (speed * -1, upFly);
		}
	}
	
	void OnTriggerEnter2D () {
		ResetDirection ();
	}
	
	void ResetDirection () {
		direction = (Random.value < .5);
	}
}

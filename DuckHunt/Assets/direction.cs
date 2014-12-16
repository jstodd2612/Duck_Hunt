using UnityEngine;
using System.Collections;

public class direction : MonoBehaviour 
{
	public float speed = .05f;
	public bool birdfly = true;
	
	void Start () {
		ResetDirection ();
	}
	
	void Update () {
		if (birdfly) {
			transform.position += new Vector3 (speed, speed);
		} else {
			transform.position += new Vector3 (speed * -1, speed);
		}
	}
	
	void OnTriggerEnter2D () {
		ResetDirection ();
	}
	
	void ResetDirection () {
		birdfly = (Random.value < .5);
	}
}
using UnityEngine;
using System.Collections;

public class Direction : MonoBehaviour {

	public float speed = .5f;
	public bool direction = false;
	
	void Start () {
		direction = (Random.value < .5);
	}
	
	void Update () {
		if (direction) {
			transform.position += new Vector3 (speed, speed);
		}else{
			transform.position += new Vector3 (speed * -1, speed);
		}
	}
}


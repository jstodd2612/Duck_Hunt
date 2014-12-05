using UnityEngine;
using System.Collections;

public class direction : MonoBehaviour 
{

	public float speed = .03f;
	public bool birddirection = false;
	
	void Start () {
		birddirection = (Random.value < .5);
	}
	
	void Update () {
		if (birddirection) {
			transform.position += new Vector3 (speed, speed);
		} 
		else{
			transform.position += new Vector3 (speed * -1, speed);
		}
	}
}
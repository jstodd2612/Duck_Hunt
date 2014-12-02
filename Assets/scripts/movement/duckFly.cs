using UnityEngine;
using System.Collections;

public class duckFly : MonoBehaviour {

	public float moveSpeed = 3f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		int RandomNum = Random.Range(1,4);

		switch(RandomNum){ //Still need to add time to the random movement.
		 //Otherwise the movement is only for a millisecond in one direction.
		case 1:
			transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
			break;

		case 2:
			transform.Translate(-Vector2.up * moveSpeed * Time.deltaTime);
			break;

		case 3:
			transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
			break;

		case 4:
			transform.Translate(-Vector2.right * moveSpeed * Time.deltaTime);
			break;
		}
	}
}

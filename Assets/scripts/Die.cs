using UnityEngine;
using System.Collections;

public class Die : MonoBehaviour {

	private int score = 0;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Space)) {
			Destroy(gameObject, 1f);
			score = score + 10;
			Debug.Log("Score: " + score);
		}

	
	}
}
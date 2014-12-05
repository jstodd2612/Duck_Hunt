using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BirdScript: MonoBehaviour {

	public float speed = .05f;
	public bool direction = false;



	public int score;
	public Text scoreText;
	public GameObject Bird;

	void Start() {
		score = 0;
		direction = (Random.value < .5);
	}

	void Update (){
		if (direction) {
			transform.position += new Vector3 (speed, speed);
		} 
		else {
			transform.position += new Vector3 (speed * -1, speed);
		}
		}
	
	void OnMouseDown () {
		UpdateScore ();
		Object.Destroy (Bird);
	}



	void UpdateScore(){
		score += 10;
		scoreText.text = "Score:" + score;
	}

	void OnTriggerEnter2D (){
		Destroy (Bird);
		}
}
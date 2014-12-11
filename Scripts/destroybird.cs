using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class destroybird : MonoBehaviour {

	public int score;
	public Text scoreText;
	public GameObject Bird;
	
	void Start() {
		score = 0;
		UpdateScore ();
		
	}
	
	void OnMouseDown () {
		//Debug.Log ("work");
		//Destroy (gameObject);
		score += 1;
		UpdateScore ();
		Bird.SetActive (false);
	}
	
	void UpdateScore () {
		scoreText.text = "Score: " + score;
	}
}


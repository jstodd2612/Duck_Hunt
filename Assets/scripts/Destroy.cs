using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Destroy : MonoBehaviour {
	
	public int score;
	public Text scoreText;
	public GameObject Bird;
	
	void Start() {
		score = 5;
		UpdateScore ();
		
	}
	
	void OnMouseDown () {
		//Debug.Log ("work");
		//Destroy (gameObject);
		score += 5;
		UpdateScore ();
		Bird.SetActive (false);
	}
	
	void UpdateScore () {
		scoreText.text = "Score: " + score;
	}
}

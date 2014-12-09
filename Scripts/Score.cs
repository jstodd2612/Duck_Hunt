using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public int score;
	public Text scoreText;
	
	// Use this for initialization
	void Start () {
		StaticVars.gameScore = 0;
	}
	
	void OnMouseDown (){
		UpdateScore ();
	}
	// Update is called once per frame
	void UpdateScore () {
		StaticVars.gameScore += 10;
		scoreText.text = "Score" + StaticVars.gameScore;
	}
}


	using UnityEngine;
	using System.Collections;
	using UnityEngine.UI;
	
	public class ScoreScript : MonoBehaviour {
		
		
		public int score;
		public Text scoreText;
		
		void Start() {
			StaticVars.gameScore = 0;
		}
		
		void OnMouseDown () {
			UpdateScore ();
		}
		
		void UpdateScore () {
			StaticVars.gameScore += 10;
			scoreText.text = "Score"  + StaticVars.gameScore;
		}
	}
	
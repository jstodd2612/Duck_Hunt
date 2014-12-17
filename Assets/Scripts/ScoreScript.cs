using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreScript : MonoBehaviour {
	
	public Text gameText;
	
	// Use this for initialization
	void Start () {
		gameText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		gameText.text = "Score: " + StaticVars.gameScore + "   Bullets: " + 
			StaticVars.bullets + "  Ducks Killed: " + StaticVars.ducksKilled +
				"  Level: " + StaticVars.level;	
	}
}

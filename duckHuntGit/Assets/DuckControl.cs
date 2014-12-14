using UnityEngine;
using System.Collections;

public class DuckControl : MonoBehaviour {


	public SpriteRenderer[] allDucks;
	// Use this for initialization
	void OnTriggerEnter (){
		NextDuck ();
	}
	
	// Update is called once per frame
	void NextDuck () {
		if (StaticVars.ducksKilled < allDucks.Length) {
			allDucks [StaticVars.ducksKilled].color = Color.red;
		} 
		StaticVars.ducksKilled++;
	}
}

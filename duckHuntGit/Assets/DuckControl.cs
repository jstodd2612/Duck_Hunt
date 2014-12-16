﻿using UnityEngine;
using System.Collections;

public class DuckControl : MonoBehaviour {

	void Start()
	{
		if (StaticVars.ducksKilled < allDucks.Length) {
			//allDucks [StaticVars.ducksKilled].color = Color.red;
			for(var index = 0; index < StaticVars.ducksKilled; index++)
			{
				allDucks[index].color = Color.red;
			}
		}
	}
	
	public SpriteRenderer[] allDucks;
	// Use this for initialization
	void OnTriggerEnter (){
		NextDuck ();
	}
	
	// Update is called once per frame
	void NextDuck () {
		if (StaticVars.ducksKilled < allDucks.Length) {
			allDucks [StaticVars.ducksKilled].color = Color.red;
			for(var index = 0; index < StaticVars.ducksKilled; index++)
			{
				allDucks[index].color = Color.red;
			}
		} 
		StaticVars.ducksKilled++; 
	}

}

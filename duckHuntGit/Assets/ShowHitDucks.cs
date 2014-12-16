using UnityEngine;
using System.Collections;

public class ShowHitDucks : MonoBehaviour {

	public SpriteRenderer[] allDucks;
	public static ShowHitDucks myDucks;
	
	void OnStart(){
		ShowHitDucks.myDucks = this;
	}
	
	// Use this for initialization
	void OnTriggerEnter (){
		ColorDucks();
	}
	

	public void ColorDucks(){
		if(StaticVars.duckIsDead = true)
			StaticVars.ducksKilled++;
		else	
		for(var index = 0; index < StaticVars.ducksKilled; index++)
		{
			allDucks[index].color = Color.red;
		}
		
	}
}

using UnityEngine;
using System.Collections;
using AssemblyCSharp;

public class LoadMyGameLevel : MonoBehaviour
{
	public static LoadMyGameLevel myLevel;

	// Use this for initialization
	void Start ()
	{
		LoadMyGameLevel.myLevel = this;
	}

	
	public void initializeNewLevel() {
		if (StaticVars.ducksGeneratedCount == 10) {
			StaticVars.ducksKilled = 0;
			StaticVars.round++;
			StaticVars.duckIsDead = false;
			StaticVars.bullets = 3;
			StaticVars.ducksGeneratedCount = 0;
			Application.LoadLevel ("main_scene");
		} else {
			StaticVars.duckIsDead = false;
			StaticVars.bullets = 3;
			StaticVars.ducksGeneratedCount++;
			Application.LoadLevel ("main_scene");
		}
	}

	void OnMouseUp () {
		StaticVars.duckIsDead = false;
		StaticVars.bullets = 3;
		StaticVars.ducksGeneratedCount++;
		Application.LoadLevel ("main_scene");

	}

}


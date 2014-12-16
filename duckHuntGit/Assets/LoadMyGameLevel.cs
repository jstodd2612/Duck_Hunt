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

	// Update is called once per frame
	void Update ()
	{

	}

	
	public void initializeNewLevel() {
		StaticVars.duckIsDead = false;
		StaticVars.bullets = 3;
		StaticVars.ducksGeneratedCount++;
		Application.LoadLevel ("main_scene");
	}

	void OnMouseUp () {
		StaticVars.duckIsDead = false;
		StaticVars.bullets = 3;
		StaticVars.ducksGeneratedCount++;
		Application.LoadLevel ("main_scene");

	}

}


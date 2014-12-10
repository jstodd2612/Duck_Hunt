using UnityEngine;
using System.Collections;
using AssemblyCSharp;

public class LoadMyGameLevel : MonoBehaviour
{

	/*// Use this for initialization
	void Start ()
	{

	}
	*/
	// Update is called once per frame
	void Update ()
	{

	}

	static public void Timer (bool duckKilled)
	{

		try{
			float startTime = Time.timeSinceLevelLoad;
			Debug.Log("LoadMyGameLevel Timer() Time.time = " + Time.time + "startTime = " + startTime);
			/*do 
			{
				Debug.Log("LoadMyGameLevel Timer() Time.time = " + Time.timeSinceLevelLoad + "startTime = " + startTime);
			}
			while(Time.timeSinceLevelLoad < startTime + Constants.levelDelay);
			initializeNewLevel (duckKilled);*/
		}
		catch (UnityException e)
		{
			Debug.Log("Error: " + e.Message);
		}
	}
	
	static public void initializeNewLevel (bool duckKilled) {
		StaticVars.duckIsDead = false;
		StaticVars.bullets = 3;
		StaticVars.ducksGenerated.Add (duckKilled);
		Application.LoadLevel ("main_scene");
	}

	void OnMouseUp () {
		StaticVars.duckIsDead = false;
		StaticVars.bullets = 3;
		StaticVars.ducksGeneratedCount++;
		Application.LoadLevel ("main_scene");

	}
}


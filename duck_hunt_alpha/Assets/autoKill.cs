using UnityEngine;
using System.Collections;

public class autoKill : MonoBehaviour {

	void OnEnable()
	{
		eventManager.OnClicked += killAutomatic;
	}
	
	
	void OnDisable()
	{
		eventManager.OnClicked -= killAutomatic;
	}
	
	
	void killAutomatic()
	{
		killDuck.isDead = true;
		killDuck.anim.SetBool("isDead", true);
		killDuck.ducksKilled = killDuck.ducksKilled + 1;
		shots.gunshots = 3;
	}
}

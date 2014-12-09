using UnityEngine;
using System.Collections;

public class autoKillDog : MonoBehaviour {

	void OnEnable()
	{
		eventManager.OnClicked += catching;
	}
	
	
	void OnDisable()
	{
		eventManager.OnClicked -= catching;
	}
	
	
	void catching()
	{
		dogMovement.doganim.SetBool("duckIsDead", true);
	}
}

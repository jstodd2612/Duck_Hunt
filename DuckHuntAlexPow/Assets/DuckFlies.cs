﻿using UnityEngine;
using System.Collections;

public class DuckFlies : MonoBehaviour {

	public float nextTime = 1;
	public float currentTime = 0;
	//public static Object.Instantiate(Object original);
	
	public virtual void GenerateDuck ()
	{
		//GameObject.Instantiate (newDuck);
	}
	
	void Update () {
		if (currentTime <= Time.time) {
			currentTime = Time.time + nextTime;
			GenerateDuck ();
		}
	}


}

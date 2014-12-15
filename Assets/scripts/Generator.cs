﻿using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour {
	public float nextTime = 2.0f,
	currentTime = 0;
	
	public GameObject newDuck;
	
	void Update() {
		if (currentTime <= Time.time) {
			currentTime = Time.time + nextTime;
			Object.Instantiate(newDuck);
		}
	
		
	}
	
}

﻿using UnityEngine;
using System.Collections;

public class dog : MonoBehaviour {

	public GameObject DogObject;
	public Animator dogAnims;

	void OnTriggerEnter2D () {	
		dogAnims.SetBool ("Hit", true);
	}
}


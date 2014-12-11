﻿using UnityEngine;
using System.Collections;


public class duckMovement : MonoBehaviour {

	static public GameObject duck;
	public GameObject flyAwayBanner;

	public float Xmax = 3.8f;
	public float Xmin = -3.8f;
	public float Ymin = -1.6f;
	public float Ymax = 3.0f;
	public int moveSpeed = 1;

	private float firstDirection = 0.0f;
	private float Xrandom = Random.Range (-2.0f, 2.0f);
	private float Yrandom = Random.Range (-2.0f, 2.0f);

	void Start(){
		duck = GameObject.FindWithTag ("duckTag");
		flyAwayBanner = GameObject.FindWithTag ("flyAwayTag");
		flyAwayBanner.SetActive (false);
	}

	void Update(){
		if (StaticVars.duckIsDead == false)
			randomMovement();
		/*else {
			transform.Translate(new Vector3(Xrandom, -2.0f, 0.0f) * Time.deltaTime);
		}*/
	}

	void randomMovement() {
		if(Time.time >= firstDirection)
			firstDirection = Time.time + Random.Range (0.5f, 1.5f);

		transform.Translate(new Vector3(Xrandom,Yrandom,0.0f) * moveSpeed * Time.deltaTime);

		if (transform.position.x >= Xmax || transform.position.x <= Xmin)
			Xrandom = -Xrandom;

		if (transform.position.y >= Ymax || transform.position.y <= Ymin)
			Yrandom = -Yrandom;

		if (StaticVars.bullets == 0){
			Yrandom = 10;
			flyAwayBanner.SetActive(true);
		}
	}
}
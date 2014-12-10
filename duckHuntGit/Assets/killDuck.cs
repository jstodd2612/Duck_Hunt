﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using AssemblyCSharp;

public class killDuck : MonoBehaviour {

	private Animator anim;
	static public float duckPosition = 0.0f;
	static public GameObject dogPositionCatch;
	private bool duckKilled = false;

	void Start()
	{
		dogPositionCatch = GameObject.FindWithTag ("dogCatchTag");
		anim = GetComponent<Animator>();
		anim.SetBool("isDead", false);
	}

	void OnMouseDown()
	{
		if (StaticVars.duckIsDead != true) {
			StaticVars.gameScore = StaticVars.gameScore +  Constants.scoreIncrease;
		}

		if (StaticVars.bullets > 0 && StaticVars.duckIsDead != true) { 
			StaticVars.bullets = StaticVars.bullets - 1;
		}

		duckPosition = duckMovement.duck.transform.position.x;
		dogCatch.myDog.moveDogCatch();

		StaticVars.duckIsDead = true;
		anim.SetBool("isDead", true);


	}

	void resetStage()
	{
		StaticVars.duckIsDead = false;
	}

	static public void flyAway()
	{
		//Debug.Log("Fly away.");
	}

	void OnCollisionEnter2D(Collision2D coll){
		try{
			if (coll.gameObject.tag == "baseCollider") {
				duckKilled = true;
				duckMovement.duck.SetActive(false);
				dogCatch.myDog.runDogCatchAnim();
				Debug.Log ("Message: Duck Collision");
				LoadMyGameLevel.Timer(duckKilled);
			}
			if (coll.gameObject.tag == "topCollider") {
				duckMovement.duck.SetActive(false);
				dogLaugh.myLaughDog.animLaughDog.SetBool("duckFlyAway", true);
				LoadMyGameLevel.Timer(duckKilled);
			}

		}
		catch (UnityException e)
		{
			Debug.Log("Error: " + e.Message);
		}
	}

	/*
	void OnDestroy(){
		//position = DogPositioning.positionDog();
		dogCatch.dogPositionCatch.transform.Translate(new Vector2(DogPositioning.positionDog(), 1.85f) * Time.deltaTime);
		Debug.Log ("AM I destroyed");
	}
	*/
}
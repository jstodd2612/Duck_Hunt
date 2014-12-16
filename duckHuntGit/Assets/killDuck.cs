using UnityEngine;
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

	public void OnMouseDown()
	{
		if (StaticVars.bullets != 0) {
			if (StaticVars.duckIsDead != true)
					StaticVars.gameScore = StaticVars.gameScore + Constants.scoreIncrease;

			if (StaticVars.bullets > 0 && StaticVars.duckIsDead != true)
					StaticVars.bullets = StaticVars.bullets - 1;

			duckPosition = duckMovement.duck.transform.position.x;
			dogCatch.myDog.moveDogCatch ();

			StaticVars.duckIsDead = true;
			anim.SetBool ("isDead", true);

			duckMovement.duck.rigidbody.useGravity = true;
			shots.BulletSprites ();
		}
	}

	void resetStage()
	{
		StaticVars.duckIsDead = false;
	}

	static public void flyAway()
	{
		//Debug.Log("Fly away.");
	}

	void OnTriggerEnter(Collider coll){

			if (coll.gameObject.tag == "baseCollider") {
				duckKilled = true;
				duckMovement.duck.SetActive(false);
				dogCatch.myDog.runDogCatchAnim();
				Debug.Log ("Message: Duck Collision");
			}
			if (coll.gameObject.tag == "topCollider") {
				duckMovement.duck.SetActive(false);
				dogLaugh.myLaughDog.animLaughDog.SetBool("duckFlyAway", true);
			}

	}


}
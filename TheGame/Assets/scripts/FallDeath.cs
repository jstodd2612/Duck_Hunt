using UnityEngine;
using System.Collections;

public class FallDeath : MonoBehaviour {

	public Animator myDuck;
	public DuckFly flyS;
	public Fall fallS;

	void OnMouseDown() {
		if (StaticVars.bullets > 0) {
			StaticVars.bullets--;
			StaticVars.numOfDucks--;
			StaticVars.gameScore++;
			flyS.enabled = false;
			myDuck.SetBool ("IsHit", true);
			fallS.enabled = true;
		}

	}

	/* void Update() {
		if (StaticVars.numOfDucks == 0 && StaticVars.bullets == 0) {
			StaticVars.bullets = 10;
		}
	} */
}

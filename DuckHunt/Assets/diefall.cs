using UnityEngine;
using System.Collections;

public class diefall : MonoBehaviour {
	 

	public direction FlyState;
	public fall FallState;
	public Animator BirdAnim;

	public void OnMouseDown () {
		if (StaticVars.bullets > 0) {
			StaticVars.gameScore++;
			FlyState.enabled = false;
			FallState.enabled = true;
			BirdAnim.enabled = false;
		}
		
		
	}
	
}
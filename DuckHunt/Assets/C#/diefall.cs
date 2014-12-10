using UnityEngine;
using System.Collections;

public class diefall : MonoBehaviour {
	 

	public direction FlyState;
	public fall FallState;


	public void OnMouseDown () {
		FlyState.enabled = false;
		FallState.enabled = true;
}
	/*public override void OnMouseEnter ()
	{
		StaticVars.gameScore++;
		if (StaticVars.bullets < 0) {
			StaticVars.bullets--;
			direction.enabled = false;
			fall.enabled = true;
		}


*/}
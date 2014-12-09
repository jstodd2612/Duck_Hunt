using UnityEngine;
using System.Collections;

public class diefall : MonoBehaviour {
	
	public Direction FlyState;
	public fall FallState;
	
	public void OnMouseDown (){
		FlyState.enabled = false;
		FallState.enabled = true;
	}

}

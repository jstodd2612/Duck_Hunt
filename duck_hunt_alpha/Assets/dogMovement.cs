using UnityEngine;
using System.Collections;

public class dogMovement : MonoBehaviour {

	static public Animator doganim;
	
	
	void Start(){
		doganim = GetComponent<Animator>();
		doganim.SetBool("duckIsDead", false);
	}
	
	static public void dogCatch(){
		doganim.SetBool("duckIsDead", true);
	}
}

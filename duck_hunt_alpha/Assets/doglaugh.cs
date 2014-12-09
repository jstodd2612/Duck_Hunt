using UnityEngine;
using System.Collections;

public class doglaugh : MonoBehaviour {

	static public Animator doganim2;
	
	
	void Start(){
		doganim2 = GetComponent<Animator>();
		doganim2.SetBool("duckFlyAway", false);
	}
	
	static public void dogLaughing(){
		doganim2.SetBool("duckFlyAway", true);
	}
}

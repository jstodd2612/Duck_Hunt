using UnityEngine;
using System.Collections;

public class killDuck : MonoBehaviour {

	static public bool isDead = false;
	private Animator anim;

	void Start(){
		anim = GetComponent<Animator>();
		anim.SetBool("isDead", false);
	}

	void OnMouseDown(){
		isDead = true;
		anim.SetBool("isDead", true);
	}
}

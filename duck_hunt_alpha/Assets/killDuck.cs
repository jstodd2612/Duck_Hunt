using UnityEngine;
using System.Collections;

public class killDuck : MonoBehaviour {

	static public bool isDead = false;
	static public int ducksKilled = 0;
	//static public int dogState = 0;
	static public Animator anim;


	void Start(){
		anim = GetComponent<Animator>();
		anim.SetBool("isDead", false);
	}

	void OnMouseDown(){
		isDead = true;
		anim.SetBool("isDead", true);
		ducksKilled = ducksKilled + 1;
		shots.gunshots = 3;
		dogMovement.dogCatch();
		//dogState = 2;
	}
	static public void flyAway(){
		Debug.Log("Fly away.");
		doglaugh.dogLaughing();
	}
}

using UnityEngine;
using System.Collections;

public class killDuck : MonoBehaviour {

	static public bool isDead = false;
	static public int ducksKilled = 0;
	private Animator anim;


	void Start(){
		anim = GetComponent<Animator>();
		anim.SetBool("isDead", false);
	}

	void OnMouseDown(){
		isDead = true;
		anim.SetBool("isDead", true);
		ducksKilled = ducksKilled + 1;
		shots.gunshots = 3;
	}

	void resetStage(){
		isDead = false;
	}
	static public void flyAway(){
		Debug.Log("Fly away.");
	}
}

using UnityEngine;
using System.Collections;

public class killDuck : MonoBehaviour {

	static public bool isDead = false;
	static public int scores = 0;
	private Animator anim;
	public const int scoreIncrease = 1000;


	void Start(){
		anim = GetComponent<Animator>();
		anim.SetBool("isDead", false);
	}

	void OnMouseDown(){
		isDead = true;
		anim.SetBool("isDead", true);
		scores = scores + scoreIncrease;
		shots.gunshots = shots.gunshots - 1;
	}

	void resetStage(){
		isDead = false;
	}
	static public void flyAway(){

	}
}

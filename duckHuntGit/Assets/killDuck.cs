using UnityEngine;
using System.Collections;

public class killDuck : MonoBehaviour {

	public const int scoreIncrease = 1000;
	static public bool isDead = false;
	static public int score = 0;
	private Animator anim;
	static public float duckPosition = 0.0f;
	


	void Start()
	{
		anim = GetComponent<Animator>();
		anim.SetBool("isDead", false);
	}

	void OnMouseDown()
	{
		if (isDead != true) {
			score = score + scoreIncrease;
		}

		if (shots.gunshots > 0 && isDead != true) { 
			shots.gunshots = shots.gunshots - 1;
		}

		duckPosition = duckMovement.duck.transform.position.x;

		isDead = true;
		anim.SetBool("isDead", true);


	}

	void resetStage()
	{
		isDead = false;
	}

	static public void flyAway()
	{
		GUI.Box(new Rect (10, 10, 200, 25), "FLY AWAY!!!");
		//Debug.Log("Fly away.");
	}
}

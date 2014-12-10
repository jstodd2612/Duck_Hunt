using UnityEngine;
using System.Collections;

public class killDuck : MonoBehaviour {

	public const int scoreIncrease = 1000;
	static public bool isDead = false;
	static public int score = 0;
	private Animator anim;
	static public float duckPosition = 0.0f;
	static public GameObject dogPositionCatch;


	void Start()
	{
		dogPositionCatch = GameObject.FindWithTag ("dogCatchTag");
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
		dogCatch.myDog.moveDogCatch();

		isDead = true;
		anim.SetBool("isDead", true);


	}

	void resetStage()
	{
		isDead = false;
	}

	static public void flyAway()
	{
		//Debug.Log("Fly away.");
	}

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "baseCollider") {
			duckMovement.duck.SetActive(false);
			dogCatch.myDog.runDogCatchAnim();
			Debug.Log ("Message: Duck Collision");
		}
		if (coll.gameObject.tag == "topCollider") {
			duckMovement.duck.SetActive(false);
			dogLaugh.myLaughDog.animLaughDog.SetBool("duckFlyAway", true);
		}
	}

	/*
	void OnDestroy(){
		//position = DogPositioning.positionDog();
		dogCatch.dogPositionCatch.transform.Translate(new Vector2(DogPositioning.positionDog(), 1.85f) * Time.deltaTime);
		Debug.Log ("AM I destroyed");
	}
	*/
}
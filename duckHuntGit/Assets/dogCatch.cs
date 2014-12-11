using UnityEngine;
using System.Collections;

public class dogCatch : MonoBehaviour
{
	public GameObject dogPositionCatch;
	public GameObject dogLeash;
	public float position = 0.0f;
	public Animator animDog;
	public static dogCatch myDog;

	// Use this for initialization
	void Start ()
	{
		dogCatch.myDog = this;
		dogLeash = GameObject.FindWithTag ("dogLeashTag");
		dogPositionCatch = GameObject.FindWithTag ("dogCatchTag");
		animDog = GetComponent<Animator>();
		animDog.SetBool("duckIsDead", false);
	}

	// Update is called once per frame
	void Update ()
	{

	}
	
	//position = DogPositioning.positionDog();
	
	public void runDogCatchAnim(){
		animDog.SetBool ("duckIsDead", true);
	}

	public void moveDogCatch(){
		position = DogPositioning.positionDog();
		dogPositionCatch.transform.position = new Vector2 (position, -2.8f);
	}
}
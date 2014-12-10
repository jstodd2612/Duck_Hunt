using UnityEngine;
using System.Collections;

public class dogCatch : MonoBehaviour
{
	public GameObject dogPositionCatch;
	public bool dogActivated = false;
	public bool dogPositioned = false;
	public float position = 0.0f;
	public Animator animDog;
	public static dogCatch myDog;
	



	// Use this for initialization
	void Start ()
	{
		dogCatch.myDog = this;
		dogPositionCatch = GameObject.FindWithTag ("dogCatchTag");
		animDog = GetComponent<Animator>();
		animDog.SetBool("duckIsDead", false);
	}

	// Update is called once per frame
	void Update ()
	{

	}
	
	//position = DogPositioning.positionDog();
	
	public void moveDogCatch(){
		animDog.SetBool ("duckIsDead", true);
	}
}
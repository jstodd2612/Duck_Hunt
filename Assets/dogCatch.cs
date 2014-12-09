using UnityEngine;
using System.Collections;

public class dogCatch : MonoBehaviour
{
	private GameObject dogPositionCatch;
	public bool dogActivated = false;
	public bool dogPositioned = false;
	public float position = 0.0f;


	// Use this for initialization
	void Start ()
	{
		dogPositionCatch = GameObject.FindWithTag ("dogCatchTag");
	}

	// Update is called once per frame
	void Update ()
	{
		if (duckMovement.duck.transform.position.y < -4.0f){
			moveDogCatch();
		}
	}
	
	//position = DogPositioning.positionDog();
	
	void moveDogCatch(){
		if (dogPositioned == false) {
			position = DogPositioning.positionDog();
			transform.position = new Vector2 (position, -2.8f);
			dogPositioned = true;
		}

		if(dogActivated == false) {
			transform.Translate (new Vector2 (0.0f, 1.85f) * Time.deltaTime);

			//Stops dog from going up into the screen
			if(dogPositionCatch.transform.position.y > -1.9f){
				dogActivated = true;
			}
		}
	}
}
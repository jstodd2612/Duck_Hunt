using UnityEngine;
using System.Collections;

public class dogLaugh : MonoBehaviour
{
	private GameObject dogPositionLaugh;
	public bool dogActivated = false;

	// Use this for initialization
	void Start ()
	{
		dogPositionLaugh = GameObject.FindWithTag ("dogLaughTag");
	}

	// Update is called once per frame
	void Update ()
	{
		if (duckMovement.duck.transform.position.y > 5.0) {
			moveDogLaugh();
		}
	}

	void moveDogLaugh(){
		if (dogActivated == false) {
			transform.Translate (new Vector2 (0.0f, 1.85f) * Time.deltaTime);
			if(dogPositionLaugh.transform.position.y > -1.9f){
				dogActivated = true;
			}
		}
	}

}
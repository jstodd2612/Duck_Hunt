using UnityEngine;
using System.Collections;

public class dogLaugh : MonoBehaviour
{
	static public GameObject dogPositionLaugh;
	public bool dogActive = false;
	public bool dogDeactive = false;
	public Animator animLaughDog;
	public static dogLaugh myLaughDog;

	// Use this for initialization
	void Start ()
	{
		dogLaugh.myLaughDog = this;
		dogPositionLaugh = GameObject.FindWithTag ("dogLaughTag");
		animLaughDog = GetComponent<Animator>();
		animLaughDog.SetBool("duckFlyAway", false);
	}

	// Update is called once per frame
	void Update ()
	{

	}

	public void moveDogLaughUp(){
		var startTime = Time.time;
		if (dogActive == false) {
			transform.Translate (new Vector2 (0.0f, 1.85f) * Time.deltaTime);
			if(dogPositionLaugh.transform.position.y > -1.9f){
				dogActive = true;
			}
		}

		if (Time.time == startTime + 5 && dogActive == true) {
			transform.Translate (new Vector2 (0.0f, -2.5f) * Time.deltaTime);
			if(dogPositionLaugh.transform.position.y > -3.9f){
				dogActive = false;
			}
		}
		return;
	}

}


/* StaticVars.gameScore++;
 * if (staticVars.bullets < 0)
 *  staticVars.bullets--;
 * 
 * 
 * drag from hiearchy into asset view, on duck generator, add to the prefab, not to the scene.
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 */
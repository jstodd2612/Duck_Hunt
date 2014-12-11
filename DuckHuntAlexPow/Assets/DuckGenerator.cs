using UnityEngine;
using System.Collections;

public class DuckGenerator : MonoBehaviour
{
	//thoughts on random location generate: y value at 0 or 1, x value in vector 2 is random number between -10 and 10 (or whatever the camera is currently set at















//random generate ducks - romrell's script: 

	// 
	/*
	public float nextTime = 2;
	public float currentTime = 0;
	//current time stays at zero
	public GameObject newDuck;

	public virtual void GenerateDuck () 
		//virtual means you can override it - polymorphism 
		//dont need virtual or override, but just update script 
	{
		Object.Instantiate (newDuck);
		}

	void Update () {
		if (currentTime <= Time.time)
		//time.time is moving 
		{
			currentTime = Time.time + nextTime;
			//when they are equal, it will generate a duck 
			GenerateDuck();

		}

	}
	*/
}

/*romrell other script: 
 * public float maxRandomValue;
 * public GameObject nextButton;
 * public override void GenerateDuck() 
 * {
 * if StaticVars.bullets>0){
 * Vector2 newPos = new Vector2();
 * newPos.x = Random.Range (maxRandomValue*-1, maxRandomValue);
 * Object.Instantiate(newDuck, newPost, Quaternion.identity);
 * 
 * }else{nextButton.SetActive(true);}
 * 
 * }
 */
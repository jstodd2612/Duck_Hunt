using UnityEngine;
using System.Collections;

public class DuckGenerator : MonoBehaviour
{

//random generate ducks - romrell's script: 
	// 
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
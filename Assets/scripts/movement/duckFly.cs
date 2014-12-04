using UnityEngine;
using System.Collections;

public class duckFly : MonoBehaviour {

	public float moveSpeed = 3f;

	void FlyRandom () {

		int RandomNum = Random.Range(1,4);
		
		switch(RandomNum){ //Still need to add time to the random movement.
			//Otherwise the movement is only for a millisecond in one direction.
		case 1:
			transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
			break;
			
		case 2:
			transform.Translate(-Vector2.up * moveSpeed * Time.deltaTime);
			break;
			
		case 3:
			transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
			break;
			
		case 4:
			transform.Translate(-Vector2.right * moveSpeed * Time.deltaTime);
			break;
		}
	}

	
	// Update is called once per frame
	void Update () {

		void IntervalFly(){
			
			int RandomFlyLength = Random.Range(2,4);
			int RandomFlyInterval = Random.Range(1f,3f):
			
			InvokeRepeating("FlyRandom", "RandomFlyLength", "RandomFlyInterval");
		}
	}
}

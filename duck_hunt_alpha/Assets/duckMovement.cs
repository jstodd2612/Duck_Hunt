using UnityEngine;
using System.Collections;

public class duckMovement : MonoBehaviour {

	public float Xmax = 4.5f;
	public float Xmin = -4.5f;
	public float Ymin = -1.5f;
	public float Ymax = 2.7f;
	public int moveSpeed = 1;

	private float firstDirection = 0.0f;
	private float Xrandom;
	private float Yrandom;

	void Update(){
		if (killDuck.isDead == false){
			randomMovement();
			} 
		/*else {
			transform.Translate(new Vector3(Xrandom, -2.0f, 0.0f) * Time.deltaTime);
		}*/
	}

	void randomMovement() {
		if(Time.time >= firstDirection){

			Xrandom = Random.Range (-2.0f, 2.0f);
			Yrandom = Random.Range (-2.0f, 2.0f);

			firstDirection = Time.time + Random.Range (0.5f, 1.5f);
			}

		transform.Translate(new Vector3(Xrandom,Yrandom,0.0f) * moveSpeed * Time.deltaTime);

		if (transform.position.x >= Xmax || transform.position.x <= Xmin) {
			Xrandom = -Xrandom;
		}
		if (transform.position.y >= Ymax || transform.position.y <= Ymin) {
			Yrandom = -Yrandom;
		}

		if (shots.gunshots <= 0){
			Yrandom = 10;
		}
}
}
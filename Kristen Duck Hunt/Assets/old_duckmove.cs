using UnityEngine;
using System.Collections;

public class duckMovementOld : MonoBehaviour {
	
	public float MinForce = 20f;
	public float MaxForce = 40f;
	public float DirectionChange = 1f;
	public int moveSpeed = 5;
	
	// Use this for initialization
	void Start () {
		moveRandomly();
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x > 4.5 || transform.position.x < -4.5){
			moveRandomly();
		}
		if (transform.position.y > 2.5 || transform.position.y < -1.5){
			moveRandomly();
		}
	}
	
	void moveRandomly() {
		float force = Random.Range (MinForce, MaxForce);
		float x = Random.Range (-1f, 1f);
		float y = Random.Range (-1f, 1f);
		
		rigidbody2D.AddForce(force * new Vector2(x, y) * moveSpeed);
		
	}
}

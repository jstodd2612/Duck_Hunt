using UnityEngine;
using System.Collections;

public class flight : MonoBehaviour {
	
	public float speed = .04f;
	private bool rightDirection = false;
	public bool isAlive = true;
	public Animator DuckFlying;
	public GameObject duckGo;
	
	public virtual void OnMouseEnter()
	{
		StaticVars.gameScore += 100;
		isAlive = false;
		StaticVars.bullets--;
	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void FixedUpdate (){
		Vector3 currentPosition = rigidbody2D.transform.position;
		
		if (isAlive) {
			RandomlyChangeDirection ();
			turnAwayFromEdges ();
			//DuckFlying.SetBool("isflying",true);
			if (rightDirection) {
				currentPosition.x += speed;
			} else {
				currentPosition.x -= speed;
			}
			
			//currentPosition.x += rightDirection? speed : -speed;
			currentPosition.y += speed / 3;
			
		} else {
			//DuckFlying.SetBool("isfalling", true);
			currentPosition.y -= .1f;
			
		}
		
		rigidbody2D.transform.position = currentPosition;
	}
	
	
	void RandomlyChangeDirection() {
		if(Random.value >= .99) {
			rightDirection = !rightDirection;
		}
	}
	void turnAwayFromEdges (){
		if (rigidbody2D.transform.position.x < -5.8) {
			rightDirection = true;
		}
		if (rigidbody2D.transform.position.x > 6) {
			rightDirection = false;
		}
	}
}

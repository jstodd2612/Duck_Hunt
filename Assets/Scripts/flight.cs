using UnityEngine;
using System.Collections;

public class flight : MonoBehaviour {

	public float speed = .04f;
	private bool rightDirection = true;
	public bool isAlive = true;
	public Animator DuckFlying;
	public GameObject duckGo;

	public virtual void OnMouseEnter()
	{
		StaticVars.gameScore++;
		isAlive = false;
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
}

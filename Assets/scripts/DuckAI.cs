using UnityEngine;
using System.Collections;

public class DuckAI : MonoBehaviour {


	/* public float maxX = 6.1f,
	             minX = -6.1f,
				 maxY = 4.2f,
				 minY = -4.2f; */


	/* private float tChange = 1.0f;
	private float randomX;
	private float randomY; */	

	// public GameObject otherGameObject;
	// private DogAI otherScript;
	// private GameObject myDog;


	public float speed = 2.5f;
	/*private float reset = -5.0f;
	private int test = 5; */

	/* public int moveSpeed = 2;
	private Vector3 computerDirection = Vector3.left,
	                moveDirection = Vector3.zero,
	                newPosition = Vector3.zero; */
	
	// Use this for initialization
	void Start () {

				// transform.rotation = Quaternion.identity;
		// otherScript = GetComponent<DogAI> ();
		// 		transform.position = new Vector2 (-5.0f, 2.0f);
	    rigidbody.velocity = new Vector3 (speed, 0, 0);
		//transform.position = new Vector3 (4,0,0); 

	}


	void FixedUpdate() {

		/*if (transform.position.x >= 5.0f) {
			float newSpeed = -2.0f;
			rigidbody2D.velocity = new Vector2 (newSpeed, 0);
		} else if (transform.position.x <= -5.0f){
			rigidbody2D.velocity = new Vector2(speed, 0);
		}

		if (this.transform.position.y <= -0.8f) {
			// DestroyObject(this.gameObject);
			this.gameObject.SetActive(false);
		} */


	}

	/*void RandomMoving() {
		/*if (Time.time >= tChange) {
			randomY = Random.Range(-2.0f, 2.0f);
			tChange = Time.time + Random.Range(0.5f, 1.5f);
		} 


		transform.Translate(new Vector3(0, randomY, 0) * speed * Time.deltaTime);

		if (transform.position.x >= maxX || transform.position.x <= minX) {
			if (transform.position.x >= maxX) {
				rigidbody2D.velocity = new Vector2(-2.0f, 0);
			} else if (transform.position.x <= minX) {
				rigidbody2D.velocity = new Vector2(speed, 0);
			}
		} 
		
		if ((transform.position.y >= maxY) || (transform.position.y <= minY)) {
			randomY = -randomY;
		}
		
		Vector3 temp = transform.position;
		temp.x = Mathf.Clamp (transform.position.x, minX, maxX);
		transform.position = temp; 

		temp.y = Mathf.Clamp (transform.position.y, minY, maxY);
		transform.position = temp;	

		 
	} */



	void OnTriggerEnter(Collider _C) {
		// float speed = 2.0f;

		rigidbody.velocity = new Vector3 (speed, 0, 0);
	}

	// Update is called once per frame
	void Update () {




		// RandomMoving ();

		/* if ( (transform.position.x <= -2.9f) && (transform.position.y >= -0.5f)) {
			anim.CrossFade("flying2", 2.0f);
		}

		if ((transform.position.x >= -3.0f) && (transform.position.y >= 1.0f) ) {
			anim.CrossFade("flying1", 2.0f);
		} */



		/* if (rigidbody2D.velocity.y < 1 && transform.eulerAngles.y <= 0) {
			transform.eulerAngles = new Vector2(0, 180.0f);
		} */

		/* if (this.transform.position.x >= 5.0f) {
			rigidbody2D.velocity = new Vector2 (-2.0f, 0); 
			rigidbody2D.MoveRotation();
			// Debug.Log("You missed!");
			// DestroyObject(this.gameObject);
		} */

		/* if (this.transform.position.x <= -5.0f) {
			rigidbody2D.velocity = new Vector2(speed, 0);
		} */



		// transform.position = new Vector2 (transform.position.x, Mathf.PingPong(Time.time, 3));

/*
		Vector3 newPosition = computerDirection * (moveSpeed * Time.deltaTime);
		newPosition = transform.position + newPosition;
		newPosition.x = Mathf.Clamp (newPosition.x, -10, 5);
		transform.position = newPosition;

		if (newPosition.x > 5) {
			newPosition.x = 5;
			computerDirection.x *= -1;


		} else if (newPosition.x < -10) {
			newPosition.x = -10;
			computerDirection.x *= -1;
		}

		Vector3 newPos2 = computerDirection * (moveSpeed * Time.deltaTime);
		newPos2 = transform.position + newPos2;
		newPos2.x = Mathf.Clamp (newPos2.y, -10, 5);

		if (newPos2.y > 5) {
			newPos2.y = 5;
			computerDirection.y *= -1;
			
			
		} else if (newPos2.y < -10) {
			newPos2.y = -10;
			computerDirection.y *= -1;
		}
*/


		/* if (gameObject.transform.position.y > 3.0f) {
			transform.position = new Vector2(-5.0f, 0.0f);


		} */

		//transform.position = new Vector2(Random.Range(-5, 5), Random.Range(0, 2));
		//Vector2 pos = new Vector2 (Random.Range(1.0f, 5.0f), Random.Range(-5.0f, 2.0f));
		//transform.position = pos;

		/* if (gameObject.transform.position.x > 5.0f) {
			transform.position = new Vector2(-5.0f, 0.0f);
			// transform.position = new Vector2 (Random.Range(0.0f, 1.0f), Random.Range(1.0f, 2.0f));
		} */


	}


}

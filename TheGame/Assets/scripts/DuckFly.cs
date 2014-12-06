using UnityEngine;
using System.Collections;

public class DuckFly : MonoBehaviour {

	public Animator anim;
	public float flyUpSpeed = 0.02f;
	public float velocitySpeed = 0.04f;
	private bool flightDirection = false;

	void Start() {
		ChangeDirection ();
	}

	void ChangeDirection() {
		flightDirection = (Random.value < 0.5f);
	}

	void FlightVelocity() {
		if (!flightDirection) {
			transform.position += new Vector3 (velocitySpeed, flyUpSpeed, 0);
		} else {
			transform.position += new Vector3(velocitySpeed * -1, flyUpSpeed, 0);
			// transform.LookAt(target2);
		}
	}

	void Update() {
		FlightVelocity ();
	}

	void OnTriggerEnter2D() {
		ChangeDirection ();

	}

}

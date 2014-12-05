using UnityEngine;
using System.Collections;

public class FlySimple : MonoBehaviour {

	public float flightSpeed = 0.04f;

	void Start() {
		rigidbody2D.velocity = new Vector2 (1.5f, 0);
	}

	public virtual void ChangeFlightPosition() {
		transform.position += new Vector3 (0, flightSpeed, 0);
	}

	// Update is called once per frame
	void Update () {
		ChangeFlightPosition ();
	}
}

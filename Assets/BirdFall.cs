using UnityEngine;
using System.Collections;

public class BirdFall : MonoBehaviour {
	public float fallSpeed = .1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3 (0, -fallSpeed);
	}

	void OnTriggerEnter2D () {
		Object.Destroy (this.gameObject);
		}
}

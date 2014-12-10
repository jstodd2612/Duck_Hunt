using UnityEngine;
using System.Collections;

public class BirdKilled : MonoBehaviour {

	public GameObject bird;
	
	void OnTriggerEnter2D () {
		Object.Destroy (bird);
	
	}

}

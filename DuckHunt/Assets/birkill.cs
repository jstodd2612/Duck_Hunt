using UnityEngine;
using System.Collections;

public class birkill : MonoBehaviour {
	
	public GameObject bird;
	public Animator dogAnim;

	void OnTriggerEnter2D () {
		Object.Destroy (bird);
	}
}
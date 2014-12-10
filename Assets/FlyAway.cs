using UnityEngine;
using System.Collections;

public class FlyAway: MonoBehaviour {

	public GameObject dog;
	public Animator dogAnims;

	void OnTriggerEnter2D () {
		dogAnims.SetBool ("BirdMiss", true);
	}
}

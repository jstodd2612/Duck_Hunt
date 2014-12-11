using UnityEngine;
using System.Collections;

public class dogmock : MonoBehaviour {

	public GameObject DogObject;
	public Animator dogAnims;

	void OnTriggerEnter2D () {
		dogAnims.SetBool ("BirdMiss", true);
	}
}
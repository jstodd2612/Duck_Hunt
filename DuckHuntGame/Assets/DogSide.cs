using UnityEngine;
using System.Collections;

public class DogSide : MonoBehaviour {

	public GameObject dog;
	public Animator dogAnims;

	void OnTriggerEnter2D () {

		dogAnims.SetBool ("hit", true);

		}
	
}

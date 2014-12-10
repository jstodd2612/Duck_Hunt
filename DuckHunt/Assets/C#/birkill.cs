using UnityEngine;
using System.Collections;

public class birkill : MonoBehaviour {
	
	public GameObject bird;

	void OnTriggerEnter2D () {

		Object.Destroy (bird);
		StaticVars.gameScore++;
		}
}
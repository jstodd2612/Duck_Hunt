using UnityEngine;
using System.Collections;

public class BirdKill : MonoBehaviour {

	public GameObject bird;

	void OnTriggerEnter2D () {
		Object.Destroy (bird);
		StaticVars.gameScore++;
		}
}

using UnityEngine;
using System.Collections;

public class birdkill : MonoBehaviour {

	public GameObject bird;
	// Use this for initialization
	void OnTriggerEnter2D (){
		Object.Destroy (bird);
		StaticVars.gameScore++;
	}
}

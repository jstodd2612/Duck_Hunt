using UnityEngine;
using System.Collections;

public class birdkill : MonoBehaviour {

	public GameObject bird;
	void OnTriggerEnter2D (){
		Object.Destroy (bird);

	}
}

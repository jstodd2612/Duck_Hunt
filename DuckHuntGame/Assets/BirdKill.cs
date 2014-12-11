using UnityEngine;
using System.Collections;

public class BirdKill : MonoBehaviour {

	public GameObject bird;
	public Animator dogAnim;

	void OnTriggerEnter2D () {
		Object.Destroy (bird);
		}
}

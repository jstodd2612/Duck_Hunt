using UnityEngine;
using System.Collections;

public class dogmock : MonoBehaviour {

	public GameObject dogObject;
	public Animator dogAnims;

	void OnTriggerEnter2D () {	
		dogAnims.SetBool ("Miss", true);
	}
}
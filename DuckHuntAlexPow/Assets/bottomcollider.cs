using UnityEngine;
using System.Collections;

public class bottomcollider : MonoBehaviour {

	public Animator dogAnims;


	void OnTriggerEnter2D (Collider2D duck) {
		dogAnims.SetBool ("hit", true);
		
		
	}

}

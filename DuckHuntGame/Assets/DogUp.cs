using UnityEngine;
using System.Collections;

public class DogUp : MonoBehaviour {

	public GameObject dog;
	public Animator dogAnims;
	
	void OnTriggerEnter2D () {
		
		dogAnims.SetBool ("miss", true);
		
	}

}

using UnityEngine;
using System.Collections;

public class DogReset : MonoBehaviour {

	public Animator dogAnims;

	void ResetDog () {
		dogAnims.SetBool ("miss", false);
		dogAnims.SetBool ("hit", false);
	}
	
}

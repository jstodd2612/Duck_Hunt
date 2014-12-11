using UnityEngine;
using System.Collections;

public class ResetDog : MonoBehaviour {

	public Animator dogAnims;

	void DogReset () {
		dogAnims. SetBool ("BirdHit", false);
		dogAnims.SetBool ("BirdMiss", false);
	}
}
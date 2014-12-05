using UnityEngine;
using System.Collections;

public class ResetAnimState : MonoBehaviour {

	public Animator Dog;

	// Use this for initialization
	void Start () {
		Dog = GetComponent<Animator> ();
	}

	void ResetState() {;
		Dog.SetBool ("miss", false);
		Dog.SetBool ("hit", false);
	}


}

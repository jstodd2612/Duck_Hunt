using UnityEngine;
using System.Collections;

public class EndDuck : MonoBehaviour {

	public Animator Dog;
	public ResetAnimState myAnim;
	public string dogAnimState = "miss";

	void OnTriggerEnter2D(Collider2D _c) {
			myAnim.Dog.SetBool (dogAnimState, true);
	}

}

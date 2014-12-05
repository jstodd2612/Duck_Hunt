using UnityEngine;
using System.Collections;

public class EndDuck : MonoBehaviour {

	public Animator Dog;
	public string dogAnimState = "miss";


	void OnTriggerEnter2D(Collider2D _c) {
		Debug.Log ("0");
		Dog.SetBool (dogAnimState, true);

	}

}

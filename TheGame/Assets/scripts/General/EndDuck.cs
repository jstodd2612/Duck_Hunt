using UnityEngine;
using System.Collections;

public class EndDuck : MonoBehaviour {

	public Animator Dog;
	public GameObject DogGO;
	public ResetAnimState myAnim;
	public string dogAnimState = "miss";

	void Start() {
		Dog = GetComponent<Animator> ();
	}

	public virtual void OnTriggerEnter(Collider _c) {
			myAnim.Dog.SetBool (dogAnimState, true);
	}

}

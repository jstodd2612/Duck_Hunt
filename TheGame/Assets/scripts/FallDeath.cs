using UnityEngine;
using System.Collections;

public class FallDeath : MonoBehaviour {

	public DuckFly flyS;
	public Fall fallS;


	void OnMouseDown() {
		flyS.enabled = false;
		fallS.enabled = true;

	}
}

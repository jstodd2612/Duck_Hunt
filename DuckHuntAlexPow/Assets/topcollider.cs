using UnityEngine;
using System.Collections;

public class topcollider : MonoBehaviour {

	public Animator dogAnims;

	void OnTriggerEnter2D (Collider2D duck) {
		dogAnims.SetBool ("miss", true);

	}
}

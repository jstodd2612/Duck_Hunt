using UnityEngine;
using System.Collections;

public class duckswitch1 : MonoBehaviour {
	public Animation deadduck;
	
	void OnMouseDown () {
		Destroy (gameObject);
		animation.Play ("deadduck");//doesn't work
	}
}

/*I can't figure out how to make the dead duck animation show up after you click the duck*/
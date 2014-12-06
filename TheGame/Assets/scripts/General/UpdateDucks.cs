using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UpdateDucks : MonoBehaviour {
	public Canvas myCanvas;
	public Text numOfDucks;

	// Update is called once per frame
	void Update () {
		if (StaticVars.numOfDucks <= 10 || StaticVars.numOfDucks >= 0) {
			numOfDucks.text = "Ducks hit: " + StaticVars.numOfDucks.ToString ();
		} 

	}
}

using UnityEngine;
using System.Collections;

public class gui : MonoBehaviour {

	// Use this for initialization


	void OnGUI() {

		GUI.Box(new Rect (150, 15, 200, 25), "Score: " + StaticVars.gameScore);

	}
}
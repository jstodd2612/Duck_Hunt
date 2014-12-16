using UnityEngine;
using System.Collections;

public class KeepScore : MonoBehaviour {
	void OnGUI() {
		GUI.Label(new Rect(10, 240, 100, 100), "Score: " + StaticVars.gameScore);
		GUI.Label(new Rect(10, 260, 100, 100), "Bullets: " + StaticVars.bullets);
	}




}
using UnityEngine;
using System.Collections;

public class gui : MonoBehaviour {

	// Use this for initialization


	void OnGUI() {

		GUI.Box(new Rect (10, 10, 200, 25), "Shots Remaining: " + shots.gunshots);
		GUI.Box(new Rect (10, 40, 200, 25), "Score: " + killDuck.score);

	}
}

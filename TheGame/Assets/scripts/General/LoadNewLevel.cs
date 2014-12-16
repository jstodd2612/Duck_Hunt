using UnityEngine;
using System.Collections;

public class LoadNewLevel : MonoBehaviour {
	public string levelToLoad;

	void Update() {
		if (StaticVars.bullets == 0) {
			Application.LoadLevel(levelToLoad);
		}
	}

}

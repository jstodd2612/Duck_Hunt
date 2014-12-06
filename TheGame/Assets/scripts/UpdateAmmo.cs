using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UpdateAmmo : MonoBehaviour {
	public Canvas myCanvas;
	public Text ammoText;

	void Update() {
		ammoText.text = "Bullets: " + StaticVars.bullets.ToString () + " remaining.";

	}

}

using UnityEngine;
using System.Collections;

public class GenerateClPlus : GeneratorCl {
	public float maxRandomValue;
	// public GameObject nextButton;

	public override void GenerateDuck() {
		if (StaticVars.bullets > 0) {
			Vector3 newPos = new Vector3();
			newPos.x = Random.Range(maxRandomValue * -1, maxRandomValue);

			Object.Instantiate(newDuck, newPos, Quaternion.identity);

		} else {
			// nextButton.SetActive(true);
		} 
	}

}

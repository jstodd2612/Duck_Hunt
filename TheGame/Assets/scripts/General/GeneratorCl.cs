using UnityEngine;
using System.Collections;

public class GeneratorCl : MonoBehaviour {
	public float nextTime = 2.0f,
			     currentTime = 0;

	public GameObject newDuck;

	void Update() {
		if (currentTime <= Time.time) {
			currentTime = Time.time + nextTime;
			Object.Instantiate(newDuck);
		}
		/* if (currentTime >= 10.0f) {
			nextTime = 0;
			Time.timeScale = 0.0f;
		} */

	}

}

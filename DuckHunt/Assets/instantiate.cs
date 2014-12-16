using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class instantiate : MonoBehaviour 
{
	public GameObject newDuck;
	public float nextTime = 2;
	public float currentTime = 0;
	
	void Update() {
		if (currentTime <= Time.time) {
			currentTime = Time.time + nextTime;
			Object.Instantiate (newDuck);
		}
	}
}
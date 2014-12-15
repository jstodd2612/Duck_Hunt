using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Generate : MonoBehaviour {

	public GameObject newDuck;
	public float nextTime = 2;
	private float currentTime = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (currentTime <= Time.time) {
			currentTime = Time.time + nextTime;
			Object.Instantiate (newDuck);
				}
	
	}
}

using UnityEngine;
using System.Collections;

public class DuckNew : MonoBehaviour {

	public float nextTime = 1;
	public float currentTime = 0;
	//public GameObject newDuck;
	
	public virtual void GenerateDuck ()
	{
		//Object.Instantiate (newDuck);
	}
	
	void Update () {
		if (currentTime <= Time.time) {
			currentTime = Time.time + nextTime;
			GenerateDuck ();
		}
	}


}

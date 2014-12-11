using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Generator : MonoBehaviour
{
	public float nextTime = 2.0f;
	public float currentTime = 0.0f;
	public GameObject newDuck;
	
	//Use this for initialization
	void Start ()
	{
		CreateDuck ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		/*if (currentTime <= Time.time) {
			currentTime = Time.time + nextTime;
			Object.Instantiate(newDuck); //newDuck = 
		}*/
	}
	
	public void CreateDuck(){
		GameObject.Instantiate(newDuck);
		//Generator.newDuck = (GameObject) 
	}

	public void DeleteDuck(){
		//Destroy(newDuck);
		//newDuck = null;
	}
}


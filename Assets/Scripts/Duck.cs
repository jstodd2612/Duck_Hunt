/*
File: Duck.cs
Author: Braydon Powell
Date: November 28 2014
Controls the Duck

requires GameState.cs
Applied to a duck or disk
*/

//Enviornment declarations (Unity3D IDE)
using UnityEngine;
using System.Collections;

//Class Duck
//Controls the duck
//No parameters
//no side effects
public class Duck : MonoBehaviour 
{
	//---PROPERTIES---//
	
	//---Public---//
	
	//---Private---//
	
	//Whether or not the duck is alive
	bool isAlive = true;	

	//The time the duck was made	
	float time;
	
	//the ducks current flight destination
	Vector3 currentDestination;

	//---METHODS---//

	//function Awake
	//Called when the object is instantiated, sets the time the object was made
	//No parameters
	//No returns
	//no side effects
	void Awake()
	{
	
		//Set the time this object was instatiated. 
		time = Time.time; 

	}//end Awake


	//function Update
	//Called every frame, Calls move
	//No parameters
	//No Returns
	//no side effects
	void Update()
	{
		
		//check for fly away
		CheckForFlyAway();
		
		//Move the duck
		Move();	
	
	}//end Update
		
	//function OnMouseDown
	//Called when the bird is clicked on, calls the Kill() function
	//No parameters
	//No returns
	//Kills the bird
	void OnMouseDown()
	{
		//add points for killing the duck
		GameState.AddPoints();

		//kill the duck
		Kill();		

	}//end OnMouseDown

	//function Move
	//Moves the bird through the scene, if its still alive
	//No parameters
	//No returns
	//No side effects
	void Move()
	{
		//only move bird is alive
		if(isAlive)
		{

			//if we have reached within .5 of our destination move to another
			//if(transform.position == currentDestination)
			if(Vector3.Distance(transform.position, currentDestination ) <= 0.3)
			{
				//make a new currentDestination
				currentDestination = RandomPointGenerator();

				Debug.Log("New Destination is " + currentDestination);
			}

			//start moving to the destination.
			transform.position = Vector3.Lerp(transform.position, currentDestination, GameState.GetSpeed() * Time.deltaTime);

		}//end alive check
		
	}//end Move

	//Function RandomPointGenerator
	//Generates a Random vector point for the bird to fly to
	//no paramters
	//no Returns
	//no side effects
	static public Vector3 RandomPointGenerator()
	{
		
		//generate a new point
		float horizontalPoint = Random.Range(GameState.GetMinX(), GameState.GetMaxX());
		float verticalPoint = Random.Range(GameState.GetMinY(), GameState.GetMaxY());

		//return the new vector with the points
		return new Vector3(horizontalPoint, verticalPoint, 0f);

	}//end RandomPointGenerator

	//function CheckForFlyAway
	//Checks the time if allowed time has elapsed or if the bird is considered a fly away
	//no parameters
	//no returns
	//no side effects
	void CheckForFlyAway()
	{
		//if its been more than the allowed time, the bird is a fly away
		if((Time.time - time) > GameState.GetAllowedTime())
		{

			Debug.Log("Duck has expired, is a fly away");
			Kill();

		}

	}//end CheckForFlyAway

	//function Kill
	//Called when the bird is killed. Starts death animation and destroys object
	//No parameters
	//No returns
	//No side effects
	void Kill()
	{
		
		Debug.Log("Duck has been killed");
		isAlive = false;
		Destroy(gameObject);		

	}//end Kill
	
}//end Duck
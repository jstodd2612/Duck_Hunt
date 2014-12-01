/*
File: GameState.cs
Author: Braydon Powell
Date: November 27 2014
Holds the general state of the game and player. .

requires no other files
Not applied to a game object
*/

//Enviornment declarations (Unity3D IDE)
using UnityEngine;
using System.Collections;

//Class GameState
//Holds The Variables and methods that decide the state of the game, including diffculty, score, ammo, win or loose states.
//No parameters
//no side effects
public class GameState : MonoBehaviour 
{
	//---PROPERTIES---//

	//---Public---//
	
		//--Game Modes--//	

	//Availible Game Types
	public enum gameTypes {openingMenu, oneDuck, twoDuck, clayShooting};

	//the current Game Type
	static public gameTypes gameType;

	//The Difficulty levels in the game
	public enum difficulties {easy, medium, hard};
	
	//the current difficulty
	static	public difficulties difficulty; 

	//---Private---//

		//---Game Difficulty---//
	
	//The amount of time disks or Ducks are allowed to fly
	static private float allowedTime = 10.0f;
	
	//the speed at which disks or ducks fly.
	static private float speed = 1.0f;	
	
	//The number of shots player is allowed to take
	static private int shots = 3;
	
	//the number of points added for each duck/disk killed, should be lower for lower difficulties
	static private int pointIncrease = 5;
	
		//--Player Statistics--//
	
	//the amount of shots the player has left
	static private int shotsLeft = 3;
	
	//the total score of the player
	static private int score = 0;

	//the round the player is on
	static private int round = 0;

		//---Other Game Settings---/
	
	//The range in which ducks or disks are allowed to fly
	static private float maxX = 6.0f;
	static private float minX = -6.0f;
	static private float maxY = 4.0f;
	static private float minY = -1.0f;
	
	
	//---METHODS---//
	
	//function ChangeMode
	//Changes the Gamemode and loads the correct scene
	//Takes the game type and diffculty as a parameter
	//No returns
	//Calling ChangeMode loads/reloads the scene for the appropriate game mode
	static public void ChangeMode(gameTypes newGameType, difficulties newDifficulty)
	{
	
		//set the current game type and difficulty
		gameType = newGameType;
		difficulty = newDifficulty;
	
		//Set the difficulty variables first
		switch (newDifficulty)
		{
			
			case difficulties.easy:
				allowedTime = 20.0f;
				speed = 1.0f;
				shots = 6;
				pointIncrease = 1;
				break;
			
			case difficulties.medium:
				allowedTime = 15.0f;
				speed = 1.2f;
				shots = 4;
				pointIncrease = 3;
				break;
			
			case difficulties.hard:
				allowedTime = 10.0f;
				speed = 1.4f;
				shots = 3;
				pointIncrease = 5;
				break;
			
			//default mode uses medium setting but outputs some info to the console.
			default: 
				Debug.Log ("Could not determine game difficulty setting");
				allowedTime = 15.0f;
				speed = 1.2f;
				shots = 4;
				pointIncrease = 3;
				break;
			
		}//end switch Difficulty

		//After setting the game difficulty load the new scene.
		switch (newGameType)
		{
			
			case gameTypes.openingMenu:
				Application.LoadLevel("Opening Menu");
				break;

			case gameTypes.oneDuck:
				Application.LoadLevel("One Duck");
				break;

			case gameTypes.twoDuck:
				Application.LoadLevel("Two Ducks");
				break;
	
			case gameTypes.clayShooting:
				Application.LoadLevel("Clay Shooting");
				break;
			
			default:
				Debug.Log ("Could not determine what level you are trying load");
				Application.Quit();
				break;

		}//end switchNewGameMode	
		
	}//end ChangeMode


	//function ResetStats
	//Resets players score, round and shots
	//No parameters
	//No returns
	//No side effects
	static void ResetStats()
	{
		//set the round and update the round gui
		round = 0;
		GamePlayGUI.UpdateRound();
		
		//set the score and update the gui
		score = 0;
		GamePlayGUI.UpdateScore();

		ResetShots();

	}//end ResetGame


	//---Getters---//

	//function GetAllowedTime
	//Gets the allowed time for a duck or disk to exist and returns it
	//No parameters
	//Returns a float representing the allowed time a duck or disk should exist
	//No side effects
	static public float GetAllowedTime()
	{
	
		return allowedTime; 

	}//end GetAllowedTime;

	//function GetSpeed
	//Returns the speed at which ducks or disks move
	//No parameters
	//Returns speed as an int
	//No side effects
	static public float GetSpeed()
	{
		
		return speed; 
		
	}//end GetAllowedTime;
	
	//function GetScore
	//Returns the score
	//No parameters
	//Returns an int that represents the score
	//No side effects
	static public int GetScore()
	{
			
		return score;
		
	}//end GetScore;

	//function GetShots
	//Returns the number of shots left
	//No parameters
	//The number of shots left as an int
	//No side effects
	static public int GetShotsLeft()
	{
		
		return shotsLeft;
		
	}//end GetShots;

	//function GetRound
	//Returns the current round
	//No parameters
	//Returns the round as an int
	//No side effects
	static public int GetRound()
	{
		
		return round;
		
	}//end GetRound;

	//function GetMaxX
	//Returns the maximum allowed x axis value
	//No parameters
	//Returns a float
	//No side effects
	static public float GetMaxX()
	{
		
		return maxX;
		
	}//end GetMaxX;
	
	//function GetMaxY
	//Returns the maximum allowed Y axis value
	//No parameters
	//Returns a float
	//No side effects
	static public float GetMaxY()
	{
		
		return maxY;
		
	}//end GetMaxY;

	//function GetMinX
	//Returns the minimum allowed X axis value
	//No parameters
	//Returns a float
	//No side effects
	static public float GetMinX()
	{
		
		return minX;
		
	}//end GetMinX;

	//function GetMinY
	//Returns the minimum allowed Y axis value
	//No parameters
	//Returns a float
	//No side effects
	static public float GetMinY()
	{
		
		return minY;
		
	}//end GetMinY;
	
	//---Setters---/

	//function DeductShots
	//Simply deducts the number of shots left
	//No parameters
	//No returns
	//No side effects
	static public void DeductShots()
	{
		
		Debug.Log("Deducting Shots " + shotsLeft);
		shotsLeft--;
		
	}//end GetShots;

	//function IncrementRound
	//Simply Increases the round by 1
	//No parameters
	//No returns
	//No side effects
	static public void IncrementRound()
	{
		
		Debug.Log("Incrementing Round " + round);
		round++;
		GamePlayGUI.UpdateRound();
		
	}//end IncrementRound

	//function ResetShots
	//Sets the number of shots left back to the maximum
	//No parameters
	//No Returns
	//No side effects
	static public void ResetShots()
	{
		
		Debug.Log("Reseting Shots");
		shotsLeft = shots;
		GamePlayGUI.UpdateShots();
		
	}//end GetShots;

	//function AddPoints
	//Adds Points to the players score
	//No parameters
	//No returns
	//No side effects
	static public void AddPoints()
	{
		Debug.Log("increasing points " + score);
		score += pointIncrease;
		GamePlayGUI.UpdateScore();
		
	}//end Addpoints;
	
}//end GameState
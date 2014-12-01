/*
File: GamePicker.cs
Author: Braydon Powell
Date: November 28 2014
Hold the GamePicker class that changes the game mode.

requires GameState.cs
Applied to any object you want to be clicked on to change the game type
*/

//Enviornment declarations (Unity3D IDE)
using UnityEngine;
using System.Collections;

//Class GamePicker
//Changes the Game Type to the type specified
//No parameters
//no side effects
public class GamePicker : MonoBehaviour 
{

	//---PROPERTIES---//

	//--Public--//
	public GameState.gameTypes gameMode;	


	//--Private--//

	//---METHODS---//

	//function on mousedown
	//Calls ChangeMode with gameMode as a parameter
	//No parameters
	//No returns
	//Calling ChangeMode loads/reloads the scene for the appropriate game mode
	void OnMouseDown()
	{
		
		Debug.Log("Changing Game Mode to " + gameMode + " " + DifficultyPicker.Difficulty);
		GameState.ChangeMode(gameMode, DifficultyPicker.Difficulty);
		
	}//end OnMouseDown


}// End GamePicker

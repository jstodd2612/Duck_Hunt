/*
File: GamePlayGui.cs
Author: Braydon Powell
Date: November 29 2014
Updates the Gui

Requires Game State
Applied to an empty game object
*/

//Enviornment declarations (Unity3D IDE)using UnityEngine;
using UnityEngine;
using System.Collections;

//Class GamePlayGUI
//Controls the GUI in the Game
//No Parameters
//No Returns
//No Side Effects.
public class GamePlayGUI : MonoBehaviour {

	//---PROPERTIES---//

		//---Public---//

	static public GUIText round;
	static public GUIText score;

	//Start
	//Finds instances of the guielements and assigns them
	//no parameters
	//no returns
	//no side effects
	void Start()
	{

		round = GameObject.Find("Round").guiText;
		score = GameObject.Find("Score").guiText;		

	}//end Start

	//UpdateScore()
	//Updates the Score GuiText element
	//no parameters
	//no returns
	//no side effects
	static public void UpdateScore() 
	{

		score.text = GameState.GetScore().ToString("D6");

	}//end UpdateScore

	//UpdateRound
	//Updates the Round GuiText element
	//no parameters
	//no returns
	//no side effects
	static public void UpdateRound() 
	{
		
		round.text = "R=" + GameState.GetRound();
		
	}//end UpdateRound

	//UpdateShots
	//Updates the ShotsGui Element
	//no parameters
	//no returns
	//no side effects
	static public void UpdateShots() 
	{
		
		//needs to be developed
		
	}//end UpdateShots

	//UpdateHitMeter
	//Updates the Hit Meter Element
	//no parameters
	//no returns
	//no side effects
	static public void UpdateHitMeter() 
	{
		
		//needs to be developed
		
	}//end UpdateHitMeter

}//End GamePlayGUI

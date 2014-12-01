/*
File: DifficultyPicker.cs
Author: Braydon Powell
Date: November 28 2014

allows control of the game difficulty, still under development will eventually be applied to a gui control

requires GameState.cs
Not currently applied to a game object
*/

//Enviornment declarations (Unity3D IDE)
using UnityEngine;
using System.Collections;

//DifficultyPicker
//Will perhaps someday control a gui element that controls difficulty, for now it is staticly set to easy
//no parameters
//no returns
//no side effects
public class DifficultyPicker : MonoBehaviour
{

	//the current game difficulty
	static public GameState.difficulties Difficulty = GameState.difficulties.easy;

}//end class DifficultyPicker

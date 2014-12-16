using UnityEngine;
using System.Collections;
using System.Collections.Generic;

static public class StaticVars
{
	public static int gameScore = 0;
	public static List<bool> ducksGenerated = new List<bool>();
	public static int ducksGeneratedCount = 0;
	public static int ducksKilled = 0;
	public static bool duckIsDead = false;
	public static int bullets = 3;
	public static SpriteRenderer[] allDucks;
}
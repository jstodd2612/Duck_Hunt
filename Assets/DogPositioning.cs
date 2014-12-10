using UnityEngine;
using System.Collections;

public class DogPositioning : MonoBehaviour
{

	public const float dogCorrection = 0.75f;
	public const float dogStartPosition_Y = -2.8f;
	const float treeCenter = -2.3f;
	const float treeRight = -1.8f;
	const float treeLeft = -2.8f;
	const float bushCenter = 2.8f;
	const float bushRight = 3.2f;
	const float bushLeft = 2.4f;
	
	static public float positionDog()
	{
		//If Duck falls in the tree area
		if(killDuck.duckPosition < 0){
			if(killDuck.duckPosition < treeCenter && killDuck.duckPosition > treeLeft){
				return killDuck.duckPosition - dogCorrection;
			}
			else if(killDuck.duckPosition < treeRight && killDuck.duckPosition > treeCenter){
				return killDuck.duckPosition + dogCorrection;
			}
		}

		//If Duck falls in the bush area
		if(killDuck.duckPosition > 0){
			if(killDuck.duckPosition < bushCenter && killDuck.duckPosition > bushLeft){
				return killDuck.duckPosition - dogCorrection;
			}
			else if(killDuck.duckPosition < bushRight && killDuck.duckPosition > bushCenter){
				return killDuck.duckPosition + dogCorrection;
			}
		}	
		return killDuck.duckPosition;
	}


}
		



using UnityEngine;
using System.Collections;

public class shots : MonoBehaviour {

	static public int gunshots = 3;

	void Start(){
		//Physics.IgnoreCollision();
	}

	void OnMouseDown(){
		gunshots = gunshots - 1;
	}

	void Update(){

		if(gunshots <= 0){
			killDuck.flyAway();
			gunshots = 0;

		}

	}


}
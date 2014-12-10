using UnityEngine;
using System.Collections;

public class shots : MonoBehaviour {

	static public int gunshots = 3;

	void Start(){
		//Physics.IgnoreCollision();
	}

	void OnMouseDown(){
		if (gunshots > 0 && killDuck.isDead != true) { 
			gunshots = gunshots - 1;
		}

	}

	void Update(){

		if(gunshots <= 0){
			killDuck.flyAway();

		}

	}


}
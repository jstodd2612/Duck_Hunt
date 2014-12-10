using UnityEngine;
using System.Collections;

public class shots : MonoBehaviour {



	void Start(){
		//Physics.IgnoreCollision();
	}

	void OnMouseDown(){
		if (StaticVars.bullets > 0 && StaticVars.duckIsDead != true) { 
			StaticVars.bullets = StaticVars.bullets - 1;
		}

	}

	void Update(){

		if(StaticVars.bullets <= 0){
			killDuck.flyAway();

		}

	}


}
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class shots : MonoBehaviour {

	public GameObject shotOn;
	
	void Start(){
		//Physics.IgnoreCollision();
	}
	void OnMouseDown(){
		if (StaticVars.bullets > 0 && StaticVars.duckIsDead != true) { 
			StaticVars.bullets = StaticVars.bullets - 1;
			BulletSprites();
		}

	}
	static public void BulletSprites (){
				if (StaticVars.bullets == 2) {
						GameObject.FindWithTag ("bullet1").SetActive (false);
				} else if (StaticVars.bullets == 1) {
						GameObject.FindWithTag ("bullet2").SetActive (false);
				} else if (StaticVars.bullets == 0) {
						GameObject.FindWithTag ("bullet3").SetActive (false);
						GameObject.FindWithTag ("shotOn").SetActive (false);
			}
		}

	void Update(){

		if(StaticVars.bullets <= 0){
			killDuck.flyAway();

		}

	}
}
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class shots : MonoBehaviour {
	
	//public List<GameObject> bullets = new List<GameObject>();
	public GameObject shotOn;
	public GameObject[] guiDuck;


	void Start(){
		//Physics.IgnoreCollision();
			guiDuck = GameObject.FindGameObjectsWithTag ("duckGUIhit");
	}
	void OnMouseDown(){
		if (StaticVars.bullets > 0 && StaticVars.duckIsDead != true) { 
			StaticVars.bullets = StaticVars.bullets - 1;
			BulletSprites();
			DuckGUIHit();
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


	public void DuckGUIHit (){
		guiDuck[0].SetActive(false);
		//guiDuck.Remove;
		}


	void Update(){

		if(StaticVars.bullets <= 0){
			killDuck.flyAway();

		}

	}
}
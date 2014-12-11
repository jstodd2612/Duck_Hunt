using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class shots : MonoBehaviour {
	
	//public List<GameObject> bullets = new List<GameObject>();
	public GameObject shotOn;
	public GameObject[] guiDuck;
	//public static GameObject[] (string "duckGUIhit");

	void Start(){
		//Physics.IgnoreCollision();

		//if (guiDuck == null)
			guiDuck = GameObject.FindGameObjectsWithTag ("duckGUIhit");

		Debug.Log ("Gui duck 1: " + guiDuck [0]);
		Debug.Log ("Gui duck 2: " + guiDuck [1]);

	}
	void OnMouseDown(){
		if (StaticVars.bullets > 0 && StaticVars.duckIsDead != true) { 
			StaticVars.bullets = StaticVars.bullets - 1;
			//bullets[0].SetActive(false); //this needs to be attached to the array when an element is removed
			//bullets.RemoveAt(0);
			BulletSprites();
		}

	}
	public void BulletSprites (){
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
		//guiDuck[0] = GameObject.SetActive(false);
		//guiDuck.Remove;
		}


	void Update(){

		if(StaticVars.bullets <= 0){
			killDuck.flyAway();

		}

	}
}
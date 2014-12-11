using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class shots : MonoBehaviour {

<<<<<<< .merge_file_a11216
=======
	static public int gunshots = 3;
	//public List<GameObject> bullets = new List<GameObject>();
	public GameObject shotOn;
>>>>>>> .merge_file_a20784


	void Start(){
		//Physics.IgnoreCollision();
		//bullets.Add(new GameObject(GameObject.FindGameObjectsWithTag("bullets");));
		//shotOn = GameObject.FindGameObjectWithTag ("shotOn");
	}

	void OnMouseDown(){
<<<<<<< .merge_file_a11216
		if (StaticVars.bullets > 0 && StaticVars.duckIsDead != true) { 
			StaticVars.bullets = StaticVars.bullets - 1;
=======
		if (gunshots >= 0 && killDuck.isDead != true) { 
			gunshots = gunshots - 1;
			//bullets[0].SetActive(false); //this needs to be attached to the array when an element is removed
			//bullets.RemoveAt(0);
			BulletSprites();
>>>>>>> .merge_file_a20784
		}

	}
	public void BulletSprites (){
				if (gunshots == 2) {
						GameObject.FindWithTag ("bullet1").SetActive (false);
				} else if (gunshots == 1) {
						GameObject.FindWithTag ("bullet2").SetActive (false);
				} else if (gunshots == 0) {
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
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class shots : MonoBehaviour {

	static public int gunshots = 3;
	//public List<GameObject> bullets = new List<GameObject>();
	public GameObject shotOn;


	void Start(){
		//Physics.IgnoreCollision();
		//bullets.Add(new GameObject(GameObject.FindGameObjectsWithTag("bullets");));
		//shotOn = GameObject.FindGameObjectWithTag ("shotOn");
	}

	void OnMouseDown(){
		if (gunshots >= 0 && killDuck.isDead != true) { 
			gunshots = gunshots - 1;
			//bullets[0].SetActive(false); //this needs to be attached to the array when an element is removed
			//bullets.RemoveAt(0);
			BulletSprites();
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

		if(gunshots <= 0){
			killDuck.flyAway();

		}

	}
}
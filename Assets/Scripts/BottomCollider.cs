using UnityEngine;
using System.Collections;

public class BottomCollider : MonoBehaviour {
	
	public Animator Dog;
	public GameObject nextButton;
	private float disableAnimation;
	
	public void OnTriggerEnter2D (Collider2D _c){
		GameObject duck = Object.Instantiate (_c.gameObject) as GameObject;
		flight f = duck.GetComponent("flight") as flight;
		f.isAlive = true;
		duck.rigidbody2D.transform.position = new Vector3(.5f, -1f, 0f);
		StaticVars.shouldSpawnNewDuck = false;
		
		
		Object.Destroy (_c.gameObject);
		Dog.SetBool ("hit", true);
		disableAnimation = Time.time + 1f;
		StaticVars.shouldSpawnNewDuck = true;
		
		
		if (StaticVars.bullets <= 0) {
			StaticVars.level++;
			StaticVars.bullets = 10;
		}

		StaticVars.ducksKilled++;
		//StaticVars.shouldSpawnNewDuck = true;
	}

	void Update() {
		if (disableAnimation < Time.time)
						Dog.SetBool ("hit", false);

	}
}
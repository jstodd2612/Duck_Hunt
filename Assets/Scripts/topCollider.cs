using UnityEngine;
using System.Collections;

public class topCollider : MonoBehaviour {
	
	public Animator Dog;
	private float animationTimer;
	
	public void OnTriggerEnter2D (Collider2D _c){
		GameObject duck = Object.Instantiate (_c.gameObject) as GameObject;
		flight f = duck.GetComponent("flight") as flight;
		f.isAlive = true;
		duck.rigidbody2D.transform.position = new Vector3(.5f, -1f, 0f);
		StaticVars.shouldSpawnNewDuck = false;
		
		
		Object.Destroy (_c.gameObject);
		Dog.SetBool ("miss", true);
		animationTimer = Time.time + 1f;
	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (animationTimer < Time.time)
						Dog.SetBool ("miss", false);
	}
}

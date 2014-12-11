using UnityEngine;
using System.Collections;

public class topCollider : MonoBehaviour {

	public Animator Dog;
	
	void OnTriggerEnter2D (Collider2D _c){
		Object.Destroy (_c.gameObject);
		Dog.SetBool ("miss", true);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

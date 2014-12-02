using UnityEngine;
using System.Collections;

public class DuckDies : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{



	}
	void onMouseDown(){
		Destroy (gameObject);

	}
	//when duck hits collider, destroy. so, top collider and bottom collider. it falls when clicked, then dies when hit bottom collider 
}

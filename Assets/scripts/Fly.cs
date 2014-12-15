using UnityEngine;
using System.Collections;

public class Fly : MonoBehaviour {

	public float speed = 5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		int RandomNum = Random.Range(1,4);

		switch(RandomNum){ 
		 
		case 1:
			transform.Translate(Vector2.up * speed * Time.deltaTime);
			break;

		case 2:
			transform.Translate(-Vector2.up * speed * Time.deltaTime);
			break;

		case 3:
			transform.Translate(Vector2.right * speed * Time.deltaTime);
			break;
		case 4:
			transform.Translate(-Vector2.right * speed * Time.deltaTime);
			break;



		}
	}
}

using UnityEngine;
using System.Collections;

public class DogScript : MonoBehaviour {

	public Animator dogAnims;
	public GameObject dogGO;
	public string dogAnimState = "miss";


	void OnMouseDown () {

		dogAnims.SetBool (dogAnimState, true);
		}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}
}

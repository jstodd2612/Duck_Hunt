using UnityEngine;
using System.Collections;

public class LoadMyGameLevel : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{

	}

	void OnMouseUp () {
		killDuck.isDead = false;
		Application.LoadLevel ("main_scene");

	}
}


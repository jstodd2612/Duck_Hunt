using UnityEngine;
using System.Collections;

public class dogLaugh : MonoBehaviour
{
	static public GameObject dogPositionLaugh;
	public Animator animLaughDog;
	public static dogLaugh myLaughDog;

	// Use this for initialization
	void Start ()
	{
		dogLaugh.myLaughDog = this;
		dogPositionLaugh = GameObject.FindWithTag ("dogLaughTag");
		animLaughDog = GetComponent<Animator>();
		animLaughDog.SetBool("duckFlyAway", false);
	}

	// Update is called once per frame
	void Update ()
	{

	}

	public void LoadGameLevel(){
		LoadMyGameLevel.myLevel.initializeNewLevel ();
	}
}
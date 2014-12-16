using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public GameObject[] bulletsprite;

	// Update is called once per frame
	void Update () {
	if (StaticVars.bullets <= 3) {
		bulletsprite[StaticVars.bullets].SetActive(false);
	}
	}
}

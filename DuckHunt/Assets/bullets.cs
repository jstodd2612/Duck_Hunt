using UnityEngine;
using System.Collections;

public class bullets : MonoBehaviour {

	public GameObject[] bullet;
	
	void Update () {
		if (StaticVars.bullets <= 3 ) {
			bullet[StaticVars.bullets].SetActive(false);		
		}
	}
}
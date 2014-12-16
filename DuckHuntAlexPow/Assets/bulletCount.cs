using UnityEngine;
using System.Collections;

public class bulletCount : MonoBehaviour {
	public int subtractBullet = 1;

	void OnMouseDown () {
		

		StaticVars.bullets = (StaticVars.bullets - subtractBullet);
		
	}
}

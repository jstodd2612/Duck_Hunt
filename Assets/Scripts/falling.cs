using UnityEngine;
using System.Collections;

public class falling : MonoBehaviour {

	void OnTriggerEnter (Collider _c)
	{
		if (_c.tag == "falling") {
			Object.Destroy(this.gameObject);
		}
	}
}

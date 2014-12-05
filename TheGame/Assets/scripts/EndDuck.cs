using UnityEngine;
using System.Collections;

public class EndDuck : MonoBehaviour {

	public virtual void OnTriggerEnter2D(Collider2D _c) {

		Object.Destroy (_c.gameObject);
	}

}

using UnityEngine;
using System.Collections;

public class EndDuckPlus : EndDuck {

	public override void OnTriggerEnter(Collider _c) {

		base.OnTriggerEnter (_c);

		Vector3 vect = new Vector3 ();
		Vector3 newVect = _c.ClosestPointOnBounds (vect);
		newVect.y = 0;
		DogGO.transform.position = newVect;


	}
}

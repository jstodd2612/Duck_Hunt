using UnityEngine;
using System.Collections;

public class BottomCollider : MonoBehaviour {
	
	public Animator Dog;

	void OnTriggerEnter2D (Collider2D _c){
		Object.Destroy (_c.gameObject);
		Dog.SetBool ("hit", true);
	}

	
/*public override void OnTriggerEnter (Collider_c){
		base.OnTriggerEnter(_c);

		Vector3 vect = new Vector3 ();
		Vector3 newVect = _c.ClosestPointOnBounds(vect);
		newVect.y = 0;
		dogGo.Transform.position = newVect;
	}

/*void OnTriggerEnter2D(){
		Animation.Play ("dogmock");
	}*/

}
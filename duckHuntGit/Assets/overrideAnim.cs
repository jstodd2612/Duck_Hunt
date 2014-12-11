using UnityEngine;
using System.Collections;

public class overrideAnim : MonoBehaviour {

	public GameObject dogLeash;
	public Animator dogAnim;

	public void OnTriggerEnter (Collider baseCollider)
	{
		
		Vector3 vect = new Vector3 ();
		Vector3 newVect = baseCollider.ClosestPointOnBounds (vect);
		newVect.y = 0;
		
		dogLeash.transform.position = newVect;
		
		dogAnim.SetBool("duckIsDead", true);
		
		
	}
	
	
	






	

}

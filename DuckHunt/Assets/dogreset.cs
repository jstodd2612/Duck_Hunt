using UnityEngine;
using System.Collections;

public class dogreset : MonoBehaviour {
 	
	public Animator dogAnims;
	
		void ResetDog () {
			dogAnims.SetBool ("Miss", false);
			dogAnims.SetBool ("Hit", false); 
		}
}

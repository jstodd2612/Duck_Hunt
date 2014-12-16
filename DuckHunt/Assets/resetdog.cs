using UnityEngine;
using System.Collections;

public class resetdog : MonoBehaviour {
	
	public Animator dogAnims;
	
	void dogreset () {
		dogAnims.SetBool ("Miss", false);
		dogAnims.SetBool ("Hit", false);
	}
}

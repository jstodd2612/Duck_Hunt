using UnityEngine;
using System.Collections;

public class dogmoving : MonoBehaviour
{
	public Animator dogAnims;
	
	void ResetDog () {
		dogAnims.SetBool ("miss", false);
		dogAnims.SetBool ("hit", false);
	}
}


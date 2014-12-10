using UnityEngine;
using System.Collections;

public class worldSpace : MonoBehaviour {
	public Transform target;
		
	void Update() {
			
			Vector3 viewPos = camera.WorldToViewportPoint(target.position);
			if (viewPos.x > 0.5F)
				print("target is on the right side!");
			else
				print("target is on the left side!");
		}
	}
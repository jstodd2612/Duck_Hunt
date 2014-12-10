using UnityEngine;
using System.Collections;

public class fall : MonoBehaviour {



	public float fallSpeed = .1f;

	void Update () {
		transform.position += new Vector3 (0, -fallSpeed);
	}

		void OntriggerEnter2D () {
			Object.Destroy (this.gameObject);
		}
}


using UnityEngine;
using System.Collections;

public class Fall : MonoBehaviour {
	
	public float fallSpeed = 0.10f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3 (0, -fallSpeed, 0);
	}

	/*void OnTriggerEnter2D(Collider2D _c) {
		if (_c.tag == "DuckEnder") {
			Object.Destroy(this.gameObject);
		} 
	}*/
}

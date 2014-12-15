using UnityEngine;
using System.Collections; 

public class MovingBird : MonoBehaviour {

	public float horizontalSpeed; 
	public float verticalSpeed; 
	public float amplitude; 



	private Vector2 tempPosition; 


	void Start ()
	{

		tempPosition = transform.position; 



	}

	void FixedUpdate ()
	{

		tempPosition.x += horizontalSpeed; 
		tempPosition.y = Mathf.Sin (Time.realtimeSinceStartup * verticalSpeed) * amplitude; 
		transform.position = tempPosition; 



		}
	
}
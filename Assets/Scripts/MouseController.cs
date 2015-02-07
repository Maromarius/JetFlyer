using UnityEngine;
using System.Collections;

public class MouseController : MonoBehaviour {

	public float jetpackForce = 75.0f;
	public float forwardMovementSpeed = 3.0f;



	// Use this for initialization
	void Start () {
	
	}

	void FixedUpdate(){

		bool jetpackActive = Input.GetButton("Fire1");

		if(jetpackActive)
		{
			rigidbody2D.AddForce(new Vector2(0,jetpackForce));
		}

		Vector2 newVelocity = rigidbody2D.velocity;
		newVelocity.x = forwardMovementSpeed;
		rigidbody2D.velocity = newVelocity;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

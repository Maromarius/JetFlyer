using UnityEngine;
using System.Collections;

public class MouseController : MonoBehaviour {

	public float jetpackForce = 75.0f;




	// Use this for initialization
	void Start () {
	
	}

	void FixedUpdate(){

		bool jetpackActive = Input.GetButton("Fire1");

		if(jetpackActive)
		{
			rigidbody2D.AddForce(new Vector2(0,jetpackForce));
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

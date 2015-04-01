using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public GameObject other;
	public Camera cam = other.GetComponent<Camera>();
	float inputH = 0.0f;
	public float inputHfactor= 1.0f;
	float inputV = 0.0f;
	public float inputVfactor = 1.0f;

	void Update () 
		
		{
		Rigidbody body = this.GetComponent<Rigidbody>();

		inputH = Input.GetAxis ("Horizontal");
		if (inputH != 0.0f) {
			body.AddForce(inputH * 5, 0.0f, 0.0f);
		}

		inputV = Input.GetAxis ("Vertical");
		if (inputV > 0.0f) {
			body.AddForce(0.0f, inputV * 15, 0.0f);
			{
				cam.fieldOfView = 45;	}
			}
		}
	}



using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public GameObject cam;
	private Transform camtrans;
	private float inputH = 0.0f;
	public float inputHfactor= 1.0f;
	private float inputV = 0.0f;
	public float inputVfactor = 1.0f;

	void Start() {
		camtrans = cam.GetComponent<Transform>();
	}

	void Update () {
		camtrans.position = new Vector3 (this.transform.localPosition.x, this.transform.localPosition.y, -5.0f);

		Rigidbody body = this.GetComponent<Rigidbody>();

		inputH = Input.GetAxis ("Horizontal");
		if (inputH != 0.0f) {
			body.AddForce(inputH * 5, 0.0f, 0.0f);
		}

		inputV = Input.GetAxis ("Vertical");
		if (inputV > 0.0f) {
			body.AddForce(0.0f, inputV * 15, 0.0f);
		}
	}
}



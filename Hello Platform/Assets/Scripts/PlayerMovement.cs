using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public GameObject cam;
	private Transform camtrans;
	public GameObject mainCamera;
	private float inputH;
	private float inputV;

	public float inputHfactor;
	public float inputVfactor;
	private float deathvelocity;
	public bool grounded;

	void Start() {
		camtrans = cam.GetComponent<Transform>();
		grounded = true;
		deathvelocity = 9f;
	}
	void Awake(){
		DontDestroyOnLoad(this);
	}

	void Update () {
		camtrans.position = new Vector3 (this.transform.localPosition.x, this.transform.localPosition.y, -5.0f);

		Rigidbody body = this.GetComponent<Rigidbody>();

		inputH = Input.GetAxis ("Horizontal");
		if (inputH != 0.0f) {
			body.AddForce(inputH * inputHfactor, 0.0f, 0.0f);
		}

		if (grounded) {
			inputV = Input.GetAxis ("Vertical");
			if (inputV > 0.0f) {
				body.AddForce (0.0f, 10.0f * inputVfactor, 0.0f);
				grounded = false;
			}
		}
		if(deathvelocity < -body.velocity.y){
				this.transform.position = new Vector3(-5.24f, -2.0f, 0.0f);
			mainCamera.GetComponent<GeldDestroyer>().lifes--;
		}
	}

	void OnCollisionEnter(Collision  info)
	{
		grounded = true;
	}
}



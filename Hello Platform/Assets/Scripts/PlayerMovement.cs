using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public GameObject cam;
	private Transform camtrans;
	private float deathvelocity;
	private float inputH;
	private float inputV;
	private float deathVelocity;
	public float inputHfactor;
	public float inputVfactor;
	private float dead;
	public bool grounded;

	void Start() {
		camtrans = cam.GetComponent<Transform>();
		grounded = true;
		deathVelocity = -9f;
	}
	void Awake(){
		DontDestroyOnLoad (this);
	}

	void Update () {
		camtrans.position = new Vector3 (this.transform.localPosition.x, this.transform.localPosition.y, -5.0f);

		Rigidbody body = this.GetComponent<Rigidbody>();
		PlayerPrefs.GetString ("CurrentLevel");
		if ("3") {
			GameObject.Destroy (this);
		}
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
		if(deathVelocity > body.velocity.y){
			camtrans.GetComponent<GeldDestroyer>().Die();
			this.transform.position = new Vector3(-5.24f , -2f, 0f);
		}
		}


	void OnCollisionEnter(Collision  info)
	{
		grounded = true;
	}
}



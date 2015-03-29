using UnityEngine;

using System.Collections;


public class CubeRotator : MonoBehaviour {
	public float rotX = 0.1f;

	// Use this for initialization

	void Start () {
	

	}

	

	// Update is called once per frame

	void Update () {this.transform.Rotate(rotX, 0.3f, 0.1f);
		rotX += 0.01f;
	this.transform.position = new Vector3(5.0f * rotX, 0.0f, 0.0f);
	 	if (this.transform.position.x > 5.0f) {
			this.transform.position = new Vector3 (0.0f, 0.0f, 0.0f);
		} else {this.transform.position = new Vector3(5.0f * rotX, 0.0f, 0.0f);
		}

	}

}

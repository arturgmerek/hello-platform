using UnityEngine;

using System.Collections;


public class Faller : MonoBehaviour {


	void OnCollisionEnter(){

		Rigidbody body = this.GetComponent<Rigidbody> ();


		body.useGravity = true;

	}

}

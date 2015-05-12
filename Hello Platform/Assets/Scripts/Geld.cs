using UnityEngine;
using System.Collections;

public class Geld : MonoBehaviour {
	public GameObject mainCam;	
	void OnTriggerEnter() {
		mainCam.GetComponent<GeldDestroyer>().score++;
			Destroy(this.gameObject);

	}
}

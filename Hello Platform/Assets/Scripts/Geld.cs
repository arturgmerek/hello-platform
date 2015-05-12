using UnityEngine;
using System.Collections;

public class Geld : MonoBehaviour {
	public GameObject mainCam;
	private GeldDestroyer mainCamtrans;
	void OnTriggerEnter() {
		mainCamtrans = mainCam.GetComponent<GeldDestroyer> ();
		Destroy(this.gameObject);

	}
}

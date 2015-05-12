using UnityEngine;
using System.Collections;

public class Geld : MonoBehaviour {
	public GameObject mainCam;
	public Transform mainCamtrans;
	void OnTriggerEnter() {
		mainCamtrans = mainCam.GetComponent<GeldDestroyer>
		Destroy(this.gameObject);

	}
}

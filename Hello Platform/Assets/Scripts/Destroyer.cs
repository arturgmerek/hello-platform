using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {
	public GameObject Ball;
	public GameObject Cam;

	void Start () {
		GameObject.Destroy (Ball);
		GameObject.Destroy (Cam);
	}
}

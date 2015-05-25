using UnityEngine;

using System.Collections;


public class Teleporter : MonoBehaviour {

	void OnTriggerEnter(){

		Application.LoadLevel ("Second");

	}


}

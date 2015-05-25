using UnityEngine;

using System.Collections;


public class Teleporter : MonoBehaviour {

	void OnTriggerEnter(){
		PlayerPrefs.SetString ("CurrentLevel", "3");
		Application.LoadLevel ("Second");
		}
}
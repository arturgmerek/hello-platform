using UnityEngine;
using System.Collections;

public class GeldDestroyer : MonoBehaviour {
	public int score;
	public int lifes;

	void Start() {
		score = 0;
		lifes = 0;


	}
	void Awake(){
		DontDestroyOnLoad (this);
	}

	void OnGUI() {
		// Make a background box
		GUI.Box(new Rect(10,10,50,50), "Score\n" + score.ToString());
		GUI.Box (new Rect (60, 10, 50, 50), "Lifes\n" + lifes.ToString());
		if (PlayerPrefs.GetString("CurrentLevel") == "3") {
			GUI.Box (new Rect (900, 300, 300, 100), "Game Over");
			GUI.Button (new Rect (900, 400, 200, 50), "Continue"); 
				Application.LoadLevel ("first");
			Debug.Log ("sexujesie");
		}
	}
	public void Die(){
		if(lifes > -2){
			this.lifes --;
			}

		if(lifes < 0){
			Application.LoadLevel ("Third");

		}
	}

}
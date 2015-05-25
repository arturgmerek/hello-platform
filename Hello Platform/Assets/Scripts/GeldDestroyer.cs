using UnityEngine;
using System.Collections;

public class GeldDestroyer : MonoBehaviour {
	public int score;
	public int lifes;

	void Start() {
		score = 0;
		lifes = 5;
		PlayerPrefs.SetString ("CurrentLevel", "1");
	}
	void Awake(){
		DontDestroyOnLoad (this);
	}

	void OnGUI() {
		// Make a background box
		GUI.Box(new Rect(10,10,50,50), "Score\n" + score.ToString());
		GUI.Box (new Rect (60, 10, 50, 50), "Lifes\n" + lifes.ToString());
		if (PlayerPrefs.GetString("CurrentLevel") == "3") {
			GUI.Box (new Rect (800, 300, 300, 100), "Game Over");
			if(GUI.Button (new Rect (850, 330, 200, 50), "Continue")){ 
				Application.LoadLevel ("first");
			}
			Debug.Log ("sexujesie");
		}
	}
	public void Die(){
		if (lifes != 0) {
			this.lifes --;
		}
		else{
			PlayerPrefs.SetString ("CurrentLevel", "3");
			Application.LoadLevel ("Third");
		}
	}

}
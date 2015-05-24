using UnityEngine;
using System.Collections;

public class GeldDestroyer : MonoBehaviour {
	public int score;
	public int lifes;
	private float deathvelocity;
	void Start() {
		score = 0;
		lifes = 5;
		deathvelocity = 9f

	}
	void Awake(){
		DontDestroyOnLoad (this);
	}

	void OnGUI() {
		// Make a background box
		GUI.Box(new Rect(10,10,50,50), "Score\n" + score.ToString());
		GUI.Box (new Rect (60, 10, 50, 50), "Lifes\n" + lifes.ToString());

	}
	//(sprawdzaj co sekundę)
	public Die(){
		if(deathvelocity < -GameObject.PlayerBall.velocity.y){
			this.lifes--;

	}
	}


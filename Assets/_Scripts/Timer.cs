using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	float timeLeft = 150.0f;
	public Text text;

	
	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		text.text = "Time Left: " + Mathf.Round (timeLeft);
		if(timeLeft < 0)
		{
			GameOver();
		}
	}

	void GameOver(){
		Application.LoadLevel ("_gameOver1");
	}
}

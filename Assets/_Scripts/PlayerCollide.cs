using UnityEngine;
using System.Collections;

public class PlayerCollide : MonoBehaviour {

	private GameObject Player1 = GameObject.FindWithTag("Player");
	private GameObject Player2 = GameObject.FindWithTag("Player_2");



	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision Player1){
		if (Player1.transform.CompareTag("Player_2")) 
		{
			Application.LoadLevel("_gameOver");
		}

	}
}

using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		//Play ();
		//HowToPlay ();
		//Credits ();
		//Quit ();
		}

	public void Play(){
		Application.LoadLevel ("_main");
	}

	public void Menu(){
		Application.LoadLevel ("_menu");
	}

	public void HowToPlay(){
		Application.LoadLevel ("_howToPlay");
	}

	public void Credits(){
		Application.LoadLevel ("_credits");
	}

	public void Quit(){
		Application.Quit ();
	}

	}

